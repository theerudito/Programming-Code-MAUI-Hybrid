using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Service.Repository
{
	public class CourseTypesRepository(ApplicationContextDB db)
	{
		
		public async Task<List<TypeCourseDto>> GetTypes()
		{
			try
			{
				return await (from type in db.TypeCourseTables
							  select new TypeCourseDto
							  {
								  IdType = type.IdType,
								  Name = type.Name
							  }).ToListAsync();				
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return new List<TypeCourseDto>();
			}
		}

		public async Task<bool> PostCourseType(TypeCourseDto typeCourseDto)
		{
			try
			{
				return false;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}
	}
}