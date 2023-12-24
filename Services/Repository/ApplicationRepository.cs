using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;
using ProgrammingCode.Service.Interface;

namespace ProgrammingCode.Service.Repository
{
	public class ApplicationRepository(ApplicationContextDB db) : IMyApplication
	{
		
		public async Task<List<ApplicationDto>> GetDataApplication(int idUserDto)
		{
			try
			{
				var query = await(from app in db.ApplicationTables
								  join user in db.AuthTables on app.IdUser equals user.IdUser
								  join course in db.CourseTables on app.IdCourse equals course.IdCourse
								  join type in db.TypeCourseTables on course.IdType equals type.IdType
								  join image in db.ImagesCoursesTables on course.IdImageCourse equals image.IdImageCourse
								  where app.IdUser == idUserDto
								  select new ApplicationDto
								  {
									  IdApplication = app.IdApplication,
									  IdUser = app.IdUser,
									  IdCourse = app.IdCourse,
									  IdImageCourse = image.IdImageCourse,
									  IdType = type.IdType,
									  NameImage = image.NameImage,
									  TitleCourse = course.Name,
									  TypeName = type.Name,
									  ScoreCourse = app.ScoreCourse,
									  LikeCourse = app.LikeCourse,
									  RefImage = image.RefImage!,
									  ImageUrl = image.ImageUrl!,
									  ImageBase64 = image.ImageBase64!	
								  }
					).ToListAsync();

				return query;
			
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return new List<ApplicationDto>();
			}
		}

		public async Task<bool> PostDataApplication(ApplicationDto myApplicationDto)
		{
			try
			{
				var query = await db.ApplicationTables
					.Where(app => 
					app.IdUser == myApplicationDto.IdUser &&
					app.IdCourse == myApplicationDto.IdCourse &&
					app.IdType == myApplicationDto.IdType
					).FirstOrDefaultAsync();

				if (query is not null) return false; 
				{
					var newApp = new ApplicationTable
					{
						IdCourse = myApplicationDto.IdCourse,
						IdType = myApplicationDto.IdType,
						IdUser = myApplicationDto.IdUser,
						ScoreCourse = 0,
						LikeCourse = false
					};

                    db.ApplicationTables.Add(newApp);
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

		public async Task<bool> PutDataApplication(ApplicationDto myApplicationDto, int idApplicationDto)
		{
			try
			{
				var query = await db.ApplicationTables.Where(u => u.IdApplication == idApplicationDto).FirstOrDefaultAsync();

				if (query is null) return false;
				{
					query.IdCourse = query.IdCourse;
					query.IdType = query.IdType;
					query.IdUser = query.IdUser;
					query.ScoreCourse = query.ScoreCourse;
					query.LikeCourse = query.LikeCourse;

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

		public async Task<bool> LikeCourse(int idApplicationDto)
		{
			try
			{
				var query = await db.ApplicationTables.FindAsync(idApplicationDto);

				if (query is null) return false;
				{
					query.LikeCourse = !query.LikeCourse;
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

		public async Task<bool> ScoreCourse(int idApplicationDto)
		{
			try
			{
                var query = await db.ApplicationTables.FindAsync(idApplicationDto);

                if (query is null) return false;
				{
					var myClass = await db.MyClassTables.Where(c => c.IdType == query.IdType && c.IdCourse == query.IdCourse).ToListAsync();

					var quantityClass = myClass.Count;

					var maxScore = 100;

					var score = maxScore / quantityClass;
 
                    query.ScoreCourse += score;

                    if (query.ScoreCourse > maxScore) query.ScoreCourse = maxScore;
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

		public async Task<List<ApplicationDto>> SearchingMyApplication(string seachDataDto, int idUserDto)
		{
			try
			{
				var query = await (from app in db.ApplicationTables
								   join user in db.AuthTables on app.IdUser equals user.IdUser
								   join course in db.CourseTables on app.IdCourse equals course.IdCourse
								   join type in db.TypeCourseTables on course.IdType equals type.IdType
								   join image in db.ImagesCoursesTables on course.IdImageCourse equals image.IdImageCourse
								   where app.IdUser == idUserDto && course.Name.Contains(seachDataDto.ToUpper())
								   select new ApplicationDto
								   {
									   IdApplication = app.IdApplication,
									   IdUser = app.IdUser,
									   IdCourse = app.IdCourse,
									   IdImageCourse = image.IdImageCourse,
									   IdType = type.IdType,
									   NameImage = image.NameImage,
									   TitleCourse = course.Name,
									   TypeName = type.Name,
									   ScoreCourse = app.ScoreCourse,
									   LikeCourse = app.LikeCourse,
									   RefImage = image.RefImage!,
									   ImageUrl = image.ImageUrl!,
									   ImageBase64 = image.ImageBase64!
								   }
					).ToListAsync();

				return query;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return new List<ApplicationDto>();
			}
		}
	}
}