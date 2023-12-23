using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Service.Repository
{
	public class ImagesClassRepository(ApplicationContextDB db)
	{
		
		public async Task<List<ImagesClassDto>> GetImagesClass(string nameCourseDto)
		{
			try
			{
				return await (from imageClass in db.ImagesClassTables
							  select new ImagesClassDto
							  {
								  IdImageClass = imageClass.IdImageClass,
								  NameImage = imageClass.NameImage,
								  RefImage = imageClass.RefImage!,
								  ImageUrl = imageClass.ImageUrl!,
								  ImageBase64 = imageClass.ImageBase64!,

							  }).ToListAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new List<ImagesClassDto>();
			}
		}

		public async Task<ImagesClassDto> GetImageClassById(int idImageClassDto)
		{
			try
			{
				var query =  await (from imageClass in db.ImagesClassTables
								  where imageClass.IdImageClass == idImageClassDto
								  select new ImagesClassDto
								  {
									  IdImageClass = imageClass.IdImageClass,
									  NameImage = imageClass.NameImage,
									  RefImage = imageClass.RefImage!,
									  ImageUrl = imageClass.ImageUrl!,
									  ImageBase64 = imageClass.ImageBase64!,

								  }).FirstOrDefaultAsync();

				return query!;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new ImagesClassDto();
			}
		}

		public async Task<bool> PostImageClass(ImagesClassDto myImageClassDto)
		{
			try
			{
				var newImageClass = new ImagesClassTable
				{
					NameImage = $"img{myImageClassDto.NameImage.ToUpper()}",
					RefImage = myImageClassDto.RefImage,
					ImageUrl = myImageClassDto.ImageUrl,
					ImageBase64 = myImageClassDto.ImageBase64,
				};

				db.ImagesClassTables.Add(newImageClass);

				await db.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public async Task<bool> PutImageClass(ImagesClassDto myImageClassDto, int idImageClassDto)
		{
			try
			{
				var query = await db.ImagesClassTables.FindAsync(idImageClassDto);

				if (query == null) return false;
				{
					query.NameImage = $"img{myImageClassDto.NameImage.ToUpper()}";
					query.RefImage = myImageClassDto.RefImage;
					query.ImageUrl = myImageClassDto.ImageUrl;
					query.ImageBase64 = myImageClassDto.ImageBase64;

					await db.SaveChangesAsync();
				}

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public async Task<bool> Delete_ImageClass(int idImageClassDto)
		{
			try
			{
				var query = await db.ImagesClassTables.FindAsync(idImageClassDto);

				if (query == null) return false;
				{
					db.ImagesClassTables.Remove(query);
					await db.SaveChangesAsync();
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
	}
}