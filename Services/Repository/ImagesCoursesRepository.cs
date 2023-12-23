using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Service.Repository
{
	public class ImagesCoursesRepository(ApplicationContextDB db)
	{
	
		public async Task<List<ImagesCourseDto>> GetImagesCourses()
		{
			try
			{
				return await (from imagesCourse in db.ImagesCoursesTables
							select new ImagesCourseDto()
							{
								IdImageCourse = imagesCourse.IdImageCourse,
								ImageUrl = imagesCourse.ImageUrl!,
								RefImage = imagesCourse.RefImage!,
								NameImage = imagesCourse.NameImage!,
								ImageBase64 = imagesCourse.ImageBase64!
							}).ToListAsync();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return new List<ImagesCourseDto>();
			}
		}

		public async Task<ImagesCourseDto> GetImageCourse(int idImageCourseDto)
		{
			try
			{
				var query =  await (from imagesCourse in db.ImagesCoursesTables
							 where imagesCourse.IdImageCourse == idImageCourseDto
							  select new ImagesCourseDto()
							  {
								  IdImageCourse = imagesCourse.IdImageCourse,
								  ImageUrl = imagesCourse.ImageUrl!,
								  RefImage = imagesCourse.RefImage!,
								  NameImage = imagesCourse.NameImage!,
								  ImageBase64 = imagesCourse.ImageBase64!
							  }).FirstOrDefaultAsync();
				return query!;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return new ImagesCourseDto();
			}
		}

		public async Task<bool> PostImageCourse(ImagesCourseDto myImageCourseDto)
		{
			try
			{
				var query = new ImagesCoursesTable()
				{
					ImageUrl = myImageCourseDto.ImageUrl,
					RefImage = myImageCourseDto.RefImage,
					NameImage = $"img{myImageCourseDto.NameImage.ToUpper()}",
					ImageBase64 = myImageCourseDto.ImageBase64
				};

				db.ImagesCoursesTables.Add(query);
				await db.SaveChangesAsync();
				return true;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}

		public async Task<bool> PutImageCourse(ImagesCourseDto myImageCourseDto, int idImageCourseDto)
		{
			try
			{
				var query = await db.ImagesCoursesTables.FindAsync(idImageCourseDto);

				if (query is null) return false;
				{
					query.ImageUrl = myImageCourseDto.ImageUrl!;
					query.RefImage = myImageCourseDto.RefImage!;
					query.NameImage = $"img{myImageCourseDto.NameImage.ToUpper()}";
					query.ImageBase64 = myImageCourseDto.ImageBase64!;

					db.ImagesCoursesTables.Update(query);
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

		public async Task<bool> DeleteImageCourse(int idImageCourseDto)
		{
			try
			{
				var query = await db.ImagesCoursesTables.FindAsync(idImageCourseDto);
				if (query == null) return false;
				{
					db.ImagesCoursesTables.Remove(query);
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