using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Service.Repository
{
	public class MyClassRepository(ApplicationContextDB db)
	{
		public async Task<List<MyClassDto>> GetMyClass()
		{
			try
			{
				var query = await (from myClass in db.MyClassTables
								   join course in db.CourseTables on myClass.IdCourse equals course.IdCourse
								   join image in db.ImagesClassTables on myClass.IdImageClass equals image.IdImageClass
								   join type in db.TypeCourseTables on myClass.IdType equals type.IdType
								   select new MyClassDto
								   {
									   IdClass = myClass.IdClass,
									   IdCourse = myClass.IdCourse,
									   IdType = myClass.IdType,
									   TitleOne = myClass.TitleOne,
									   TitleTwo = myClass.TitleTwo,
									   CodeClass = myClass.CodeClass!,
									   LinkRef = myClass.LinkRef!,
									   IdImageClass = myClass.IdImageClass,   
									   InfoClass = myClass.InfoClass,
									   ImageUrl = image.ImageUrl!,
									   NameImage = image.NameImage!,
									   ImageBase64 = image.ImageBase64!,
									   RefImage = image.RefImage!,
									  
								   }
								   ).ToListAsync();
				return query;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new List<MyClassDto>();
			}
		}

		public async Task<List<MyClassDto>> FindMyClass(int IdCourseDto, int IdTypeDto)
		{
			try
			{
				var d  = await  db.MyClassTables.ToListAsync();
				var query = await (from myClass in db.MyClassTables
								   join course in db.CourseTables on myClass.IdCourse equals course.IdCourse
								   join image in db.ImagesClassTables on myClass.IdImageClass equals image.IdImageClass
								   join type in db.TypeCourseTables on myClass.IdType equals type.IdType
								   where myClass.IdCourse == IdCourseDto && myClass.IdType == IdTypeDto
								   select new MyClassDto
								   {
									   IdClass = myClass.IdClass,
									   IdCourse = myClass.IdCourse,
									   IdType = myClass.IdType,
									   TitleOne = myClass.TitleOne,
									   TitleTwo = myClass.TitleTwo,
									   CodeClass = myClass.CodeClass!,
									   LinkRef = myClass.LinkRef!,
									   IdImageClass = myClass.IdImageClass,
									   InfoClass = myClass.InfoClass,
									   ImageUrl = image.ImageUrl!,
									   NameImage = image.NameImage!,
									   ImageBase64 = image.ImageBase64!,
									   RefImage = image.RefImage!,

								   }
								   ).ToListAsync();
				return query;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new List<MyClassDto>();
			}
		}

		public async Task<bool> PostMyClass(MyClassDto myClassDto)
		{
			try
			{
				var query = new MyClassTable
				{
					IdCourse = myClassDto.IdCourse,
					IdType = myClassDto.IdType,
					TitleOne = myClassDto.TitleOne,
					TitleTwo = myClassDto.TitleTwo,
					CodeClass = myClassDto.CodeClass!,
					LinkRef = myClassDto.LinkRef!,
					IdImageClass = myClassDto.IdImageClass,
					InfoClass = myClassDto.InfoClass,
				};
				await db.MyClassTables.AddAsync(query);
				await db.SaveChangesAsync();
				return true;
				
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return true;
			}
		}

		public async Task<bool> PutMyClass(MyClassDto myClassDto, int idClassDto)
		{
			try
			{
				var query = await db.MyClassTables.FindAsync(idClassDto);

				if (query == null) return false;
				{
					query.IdCourse = myClassDto.IdCourse;
					query.IdType = myClassDto.IdType;
					query.TitleOne = myClassDto.TitleOne;
					query.TitleTwo = myClassDto.TitleTwo;
					query.CodeClass = myClassDto.CodeClass!;
					query.LinkRef = myClassDto.LinkRef!;
					query.IdImageClass = myClassDto.IdImageClass;
					query.InfoClass = myClassDto.InfoClass;
					await db.SaveChangesAsync();
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return true;
			}
		}

		public async Task<List<MyClassDto>> SeachingClass(string seachClassDto)
		{
			try
			{
				var query = await (from myClass in db.MyClassTables
								   join course in db.CourseTables on myClass.IdCourse equals course.IdCourse
								   join image in db.ImagesClassTables on myClass.IdImageClass equals image.IdImageClass
								   join type in db.TypeCourseTables on myClass.IdType equals type.IdType
								   where myClass.TitleOne.Contains(seachClassDto)
								   select new MyClassDto
								   {
									   IdClass = myClass.IdClass,
									   IdCourse = myClass.IdCourse,
									   IdType = myClass.IdType,
									   TitleOne = myClass.TitleOne,
									   TitleTwo = myClass.TitleTwo,
									   CodeClass = myClass.CodeClass!,
									   LinkRef = myClass.LinkRef!,
									   IdImageClass = myClass.IdImageClass,
									   InfoClass = myClass.InfoClass,
									   ImageUrl = image.ImageUrl!,
									   NameImage = image.NameImage!,
									   ImageBase64 = image.ImageBase64!,
									   RefImage = image.RefImage!,

								   }
								   ).ToListAsync();
				return query;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new List<MyClassDto>();
			}
		}

		public async Task<bool> DeleteClass(int idClassDto)
		{
			try
			{
				var query = await db.MyClassTables.FindAsync(idClassDto);

				if (query == null) return false;
				{
					db.MyClassTables.Remove(query);
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