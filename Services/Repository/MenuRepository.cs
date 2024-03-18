using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;
using ProgrammingCode.Service.Interface;

namespace ProgrammingCode.Service.Repository
{
    public class MenuRepository(ApplicationContextDB db) : IMenu
    {
        public async Task<List<MenuDto>> GetMenu(int idUserDto)
        {
            try
            {
                var query = await (from amt in db.AuthMenuTables
                                   join menu in db.MenuTables on amt.IdMenu equals menu.IdMenu
                                   where amt.IdUser == idUserDto
                                   select new MenuDto
                                   {
                                       IdMenu = amt.IdMenu,
                                       NameLink = menu.NameLink,
                                       NameMenu = menu.NameMenu,
                                   }).ToListAsync();
                return query;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<MenuDto>();
            }
        }

        public async Task<bool> PostMenus(string userAdmin, string userNameDto)
        {
            try
            {
                var idUser = await db.AuthTables.Where(x => x.UserName == userNameDto).FirstOrDefaultAsync();

                if (userAdmin == userNameDto)
                {
                    var menu = new List<AuthMenuTable>()
                        {
                            new AuthMenuTable{ IdMenu = 1, IdUser = idUser.IdUser },
                            new AuthMenuTable{ IdMenu = 2, IdUser = idUser.IdUser },
                            new AuthMenuTable{ IdMenu = 3, IdUser = idUser.IdUser },
                            new AuthMenuTable{ IdMenu = 4, IdUser = idUser.IdUser },
                        };

                    db.AuthMenuTables.AddRange(menu);
                    await db.SaveChangesAsync();
                    return true;
                }
                else
                {
                    var menu = new List<AuthMenuTable>()
                        {
                            new AuthMenuTable{ IdMenu = 1, IdUser = idUser.IdUser},
                            new AuthMenuTable{ IdMenu = 2, IdUser = idUser.IdUser},
                        };

                    db.AuthMenuTables.AddRange(menu);
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