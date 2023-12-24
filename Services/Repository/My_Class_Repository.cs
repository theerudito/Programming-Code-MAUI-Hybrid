using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Entity;


namespace ProgrammingCode.Service.Repository
{
	public class My_Class_Repository(ApplicationContextDB db)
	{
		public async Task<bool> PostData(int idUser, int idCourse, int idClass)
		{
			try
			{
                var query = await db.ClassTables.Where(x => x.IdUser == idUser && x.IdCourse == idCourse && x.IdClass == idClass).FirstOrDefaultAsync();
                               
                   if (query != null) return false;
                    {
                        var newClass = new ClassTable { IdUser = idUser, IdClass = idClass, IdCourse = idCourse };

                        db.ClassTables.Add(newClass);
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