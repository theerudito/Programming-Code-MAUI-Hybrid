using ProgrammingCode.Data;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Helpers
{
	public class InitialValues
	{

		public static void AddImagesClass()
		{
			var db = new ApplicationContextDB();

			var countImages  = db.ImagesClassTables.Count();

			var json = JSONManager.ReadJSON();

			var countData = json[0].Count();

			if (countImages == countData) return;
			{
				var myImages = json.FirstOrDefault()!.Select(item => new ImagesClassTable
				{
					IdImageClass = Convert.ToInt16(item.ContainsKey("idImageClass")),
					NameImage = item.ContainsKey("nameImage").ToString(),
					ImageUrl = item.ContainsKey("imageUrl").ToString(),
					RefImage = item.ContainsKey("refImage").ToString(),
					ImageBase64 = item.ContainsKey("imageBase64").ToString(),

				}).ToList();

                db.ImagesClassTables.AddRange(myImages!);

				db.SaveChanges();
				
			}
		}

		public static void AddRole()
		{
			var db = new ApplicationContextDB();
			var newData = 2;
			var query = db.RoleTables.Count();
			if (newData > query)
			{
				var newRoles = new List<RoleTable>
					{
						new RoleTable { IdRole = 1, Name = "Admin"},
						new RoleTable { IdRole = 2, Name = "User"},
					};

				db.RoleTables.AddRange(newRoles);
				db.SaveChanges();
			} else
			{
				return;
			}

			
		}
	
		public static void AddType()
		{
            var db = new ApplicationContextDB();
            var newData = 3;
            var query = db.TypeCourseTables.Count();

			if (newData > query)
			{
                var newTypes = new List<TypeCourseTable>
				{
					new TypeCourseTable { IdType = 1, Name = "Basic"},
					new TypeCourseTable { IdType = 2, Name = "Intermediate"},
                    new TypeCourseTable { IdType = 3, Name = "Advanced"},
                };

                db.TypeCourseTables.AddRange(newTypes);
                db.SaveChanges();
            }
            else
			{
                return;
            }
		}
		
		public static void Menu()
		{
            var db = new ApplicationContextDB();
            var newData = 4;
            var query = db.MenuTables.Count();

            if (newData > query) 
			{
                var menu = new List<MenuTable>()
                {
                    new MenuTable{ NameLink = "/", NameMenu = "Home"},
                    new MenuTable{ NameLink = "/about", NameMenu = "About"},
                    new MenuTable{ NameLink = "/addCourse", NameMenu = "Add Course"},
                    new MenuTable{ NameLink = "/addClass", NameMenu = "Add Class"},
                };

                db.MenuTables.AddRange(menu);
                db.SaveChanges();
            }               
        }
	}
}
