using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;
using ProgrammingCode.Service.Interface;

namespace ProgrammingCode.Service.Repository
{
	public class CourseRepository(ApplicationContextDB db) : ICourse
	{

		public async Task<List<CourseDto>> GetsCourses()
		{
			try
			{
				var query = await (from course in db.CourseTables
													 join type in db.TypeCourseTables on course.IdType equals type.IdType
													 join image in db.ImagesCoursesTables on course.IdImageCourse equals image.IdImageCourse
													 select new CourseDto
													 {
														 IdCourse = course.IdCourse,
														 IdType = course.IdType,
														 IdImageCourse = course.IdImageCourse,
														 Name = course.Name,
														 TypeName = type.Name,
														 SelectedCourse = course.SelectedCourse,
														 ImageUrl = image.ImageUrl!,
														 RefImage = image.RefImage!,
														 NameImage = image.NameImage!,
														 ImageBase64 = image.ImageBase64!
													 }).ToListAsync();
				return query;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message.ToString());
				return new List<CourseDto>();
			}
		}

		public async Task<CourseDto> GetCourseById(int idCourseDto)
		{
			try
			{
				var query = await (from course in db.CourseTables
													 join type in db.TypeCourseTables on course.IdType equals type.IdType
													 join image in db.ImagesCoursesTables on course.IdImageCourse equals image.IdImageCourse
													 where course.IdCourse == idCourseDto
													 select new CourseDto
													 {
														 IdCourse = course.IdCourse,
														 IdType = course.IdType,
														 IdImageCourse = course.IdImageCourse,
														 Name = course.Name,
														 TypeName = type.Name,
														 SelectedCourse = course.SelectedCourse,
														 ImageUrl = image.ImageUrl!,
														 RefImage = image.RefImage!,
														 NameImage = image.NameImage!,
														 ImageBase64 = image.ImageBase64!
													 }).FirstOrDefaultAsync();
				return query!;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw;
			}
		}

		public async Task<bool> PostCourse(CourseDto courseDto)
		{
			try
			{
				var mewCouse = new CourseTable
				{
					Name = courseDto.Name.ToUpper(),
					IdType = courseDto.IdType,
					IdImageCourse = courseDto.IdImageCourse,
					SelectedCourse = false
				};

				db.CourseTables.Add(mewCouse);
				await db.SaveChangesAsync();

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}

		public async Task<bool> PutCourse(CourseDto courseDto, int idCourseDto)
		{
			try
			{
				var query = await db.CourseTables.FindAsync(idCourseDto);

				if (query is null) return false;
				{
					query.Name = courseDto.Name.ToUpper();
					query.IdType = courseDto.IdType;
					query.IdImageCourse = courseDto.IdImageCourse;
					query.SelectedCourse = courseDto.SelectedCourse;
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

		public async Task<bool> DeleteCourse(int idCourseDto)
		{
			try
			{
				var query = await db.CourseTables.FindAsync(idCourseDto);

				if (query is null) return false;
				{
					db.CourseTables.Remove(query);
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

		public async Task<bool> SelectedCourse(int idCourseDto)
		{
			try
			{
				var query = await db.CourseTables.FindAsync(idCourseDto);

				if (query is null) return false;
				{
					query.SelectedCourse = true;
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

		public async Task<List<CourseDto>> SearchingCourse(string searchCourseDto)
		{
			try
			{

				var query = await (from course in db.CourseTables
													 join type in db.TypeCourseTables on course.IdType equals type.IdType
													 join image in db.ImagesCoursesTables on course.IdImageCourse equals image.IdImageCourse
													 where course.Name.Contains(searchCourseDto.ToUpper())
													 select new CourseDto
													 {
														 IdCourse = course.IdCourse,
														 IdType = course.IdType,
														 IdImageCourse = course.IdImageCourse,
														 Name = course.Name,
														 TypeName = type.Name,
														 SelectedCourse = course.SelectedCourse,
														 ImageUrl = image.ImageUrl!,
														 RefImage = image.RefImage!,
														 NameImage = image.NameImage!,
														 ImageBase64 = image.ImageBase64!
													 }).ToListAsync();
				return query;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return new List<CourseDto>();
			}
		}
	}
}