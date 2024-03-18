using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Helpers;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;
using ProgrammingCode.Service.Interface;

namespace ProgrammingCode.Service.Repository
{
    public class AuthRepository(ApplicationContextDB db, IMenu myMenu) : IAuth
    {
        public async Task<List<AuthDto>> GetAuth()
        {
            try
            {
                return await (from auth in db.AuthTables
                              select new AuthDto
                              {
                                  IdUser = auth.IdUser,
                                  Name = auth.Name,
                                  Password = auth.Password,
                                  Email = auth.Email,
                                  UserName = auth.UserName,
                              }
                    )
                    .ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<AuthDto>();
            }
        }

        public async Task<AuthDto> GetByIdAuth(int idUserDto)
        {
            try
            {
                var query = await (from auth in db.AuthTables
                                   where auth.IdUser == idUserDto
                                   select new AuthDto
                                   {
                                       IdUser = auth.IdUser,
                                       Name = auth.Name,
                                       Password = auth.Password,
                                       Email = auth.Email,
                                       UserName = auth.UserName,
                                   }
                    )
                    .FirstOrDefaultAsync();
                return query!;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new AuthDto();
            }
        }

        public async Task<bool> RegisterAuth(AuthDto userDto)
        {
            try
            {
                string userAdmin = "theboss";

                var myrole = await db.RoleTables.ToListAsync();

                var query = await db.AuthTables
                   .Where(u => u.UserName == userDto.UserName.ToLower() || u.Email == userDto.Email.ToLower())
                   .FirstOrDefaultAsync();

                if (query != null) return false;
                else
                {
                    var newUser = new AuthTable
                    {
                        Name = userDto.Name,
                        UserName = userDto.UserName.ToLower(),
                        Email = userDto.Email.ToLower(),
                        Password = BcryManager.HashPassword(userDto.Password),
                        IdRole = userDto.UserName == userAdmin ? 1 : 2
                    };

                    db.AuthTables.Add(newUser);
                    await db.SaveChangesAsync();

                    var findUser = await db.AuthTables.Where(u => u.UserName == userDto.UserName.ToLower()).FirstOrDefaultAsync();

                    if (findUser == null) return false;
                    {
                        LocalStorageDataApp.SetItem(LocalStorageDataApp.KeyUser, findUser.Name);
                        LocalStorageDataApp.SetItem(LocalStorageDataApp.KeyToken, findUser.UserName);
                        LocalStorageDataApp.SetItem(LocalStorageDataApp.KeyIdUser, findUser.IdUser.ToString());

                        await myMenu.PostMenus(userAdmin, findUser.UserName);

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }

        public async Task<bool> LoginAuth(AuthDto userDto)
        {
            try
            {
                var query = await db.AuthTables.Where(u => u.UserName == userDto.UserName.ToLower()).FirstOrDefaultAsync();

                if (query == null) return false;
                {
                    if (BcryManager.ValidatePassword(userDto.Password, query!.Password) == false) return false;
                    {
                        LocalStorageDataApp.SetItem(LocalStorageDataApp.KeyUser, query.Name);
                        LocalStorageDataApp.SetItem(LocalStorageDataApp.KeyToken, query.UserName);
                        LocalStorageDataApp.SetItem(LocalStorageDataApp.KeyIdUser, query.IdUser.ToString());
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> PutAuth(AuthDto userDto, int idUserDto)
        {
            try
            {
                var query = await db.AuthTables.FindAsync(idUserDto);

                if (query is null) return false;
                {
                    query.Name = userDto.Name;
                    query.UserName = userDto.UserName;
                    query.Email = userDto.Email;
                    query.Password = BcryManager.HashPassword(userDto.Password);

                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}