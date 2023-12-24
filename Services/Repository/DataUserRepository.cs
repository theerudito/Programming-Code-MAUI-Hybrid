using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;


namespace ProgrammingCode.Services.Repository
{
    public class DataUserRepository(ApplicationContextDB db)
    {
        public async Task<bool> AuthUser(int idUserDto)
        {
          var query = await db.AuthTables.Where(db => db.IdUser == idUserDto).ToListAsync();
            if (query == null) return false; 
            db.AuthTables.RemoveRange(query);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ApplicationUser(int idUserDto)
        {
            var query = await db.ApplicationTables.Where(db => db.IdUser == idUserDto).ToListAsync();
            if (query == null) return false;
            db.ApplicationTables.RemoveRange(query);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ClassUser(int idUserDto)
        {
            var query = await db.ClassTables.Where(db => db.IdUser == idUserDto).ToListAsync();
            if (query == null) return false;
            db.ClassTables.RemoveRange(query);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> MenuAuthUser(int idUserDto)
        {
            var query = await db.AuthMenuTables.Where(db => db.IdUser == idUserDto).ToListAsync();
            if (query == null) return false;
            db.AuthMenuTables.RemoveRange(query);
            await db.SaveChangesAsync();
            return true;
        }
    }
}
