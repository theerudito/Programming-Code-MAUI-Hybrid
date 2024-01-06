using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Helpers
{
	public class InitialValues
	{
        public static void AddRole()
		{
			var db = new ApplicationContextDB();

			var query = db.RoleTables.Where(r => r.IdRole == 1).FirstOrDefault();

			if (query != null) return;
			{
				var newRoles = new List<RoleTable>
					{
						new RoleTable { IdRole = 1, Name = "Admin"},
						new RoleTable { IdRole = 2, Name = "User"},
					};

				db.RoleTables.AddRange(newRoles);
				db.SaveChanges();
			} 
		}
	
		public static void Menu()
		{
            var db = new ApplicationContextDB();
            
            var query = db.MenuTables.Where(menu => menu.IdMenu == 1).FirstOrDefault();

            if (query != null)  return;
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
        
        public static void AddType()
        {
            var db = new ApplicationContextDB();

            var query = db.TypeCourseTables.Where(type => type.IdType == 1).FirstOrDefault();

            if (query != null) return;
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
        }

        public static void AddImagesClass()
        {
            var db = new ApplicationContextDB();

            var countImages = db.ImagesClassTables.Count();

            var json = JSONManager.ReadJSON();

            var dataFromJson = json[0]
                .Select(item => new ImagesClassTable
                {
                    IdImageClass = int.Parse(item["idImageClass"]),
                    NameImage = item["nameImage"],
                    ImageUrl = item["imageUrl"],
                    ImageBase64 = item["imageBase64"],
                    RefImage = item["refImage"]
                })
                .ToList();

            if (countImages == dataFromJson.Count)
            {
                return;
            }

            List<ImagesClassTable> imagesClass = new List<ImagesClassTable>();

            foreach (var image in dataFromJson)
            {
                if (!db.ImagesClassTables.Any(i => i.IdImageClass == image.IdImageClass))
                {
                    imagesClass.Add(image);
                }
            }

            db.ImagesClassTables.AddRange(imagesClass);

            Task.Run(() => db.SaveChangesAsync());
        }

        public static void AddImagesCourse()
        {
            var db = new ApplicationContextDB();

            var countImages = db.ImagesCoursesTables.Count();

            var json = JSONManager.ReadJSON();

            var dataFromJson = json[1]
                .Select(item => new ImagesCoursesTable
                {
                    IdImageCourse = int.Parse(item["idImageCourse"]),
                    NameImage = item["nameImage"],
                    ImageUrl = item["imageUrl"],
                    RefImage = item["refImage"],
                    ImageBase64 = item["imageBase64"]
                })
                .ToList();

            if (countImages == dataFromJson.Count)
            {
                return;
            }

            List<ImagesCoursesTable> imagesCourse = new List<ImagesCoursesTable>();

            foreach (var image in dataFromJson)
            {
                if (!db.ImagesCoursesTables.Any(i => i.IdImageCourse == image.IdImageCourse))
                {
                    imagesCourse.Add(image);
                }
            }

            db.ImagesCoursesTables.AddRange(imagesCourse);

            Task.Run(() => db.SaveChangesAsync());
        }

        public static void AddCourse()
        {
            var db = new ApplicationContextDB();

            var countCourse = db.CourseTables.Count();

            var json = JSONManager.ReadJSON();

            var myCourseFromJson = json[2]
                .Select(item => new CourseDto
                {
                    IdCourse = int.Parse(item["idCourse"]),
                    IdImageCourse = int.Parse(item["idImageCourse"]),
                    IdType = int.Parse(item["idType"]),
                    Name = item["name"],
                    TypeName = item["typeName"],
                    SelectedCourse = bool.Parse(item["selectedCourse"]),
                    NameImage = item["nameImage"],
                    ImageUrl = item["imageUrl"],
                    ImageBase64 = item["imageBase64"],
                    RefImage = item["refImage"],
                })
                .ToList();

            if (countCourse == myCourseFromJson.Count)
            {
                return;
            }

            List<CourseTable> myCourse = new List<CourseTable>();

            foreach (var course in myCourseFromJson)
            {
                if (!db.CourseTables.Any(c => c.IdCourse == course.IdCourse))
                {


                    myCourse.Add(new CourseTable 
                    { 
                        IdCourse = course.IdCourse,
                        IdImageCourse = course.IdImageCourse,
                        IdType = course.IdType,
                        Name = course.Name,
                        SelectedCourse = course.SelectedCourse,
                    });
                }
            }

            db.CourseTables.AddRange(myCourse);

            Task.Run(() => db.SaveChangesAsync());
        }

        public static void AddMyClass()
        {
            var db = new ApplicationContextDB();

            var countMyClass = db.MyClassTables.Count();

            var json = JSONManager.ReadJSON();

            var myClassFromJson = json[3]
                .Select(item => new MyClassDto
                {
                    IdClass = int.Parse(item["idClass"]),
                    TitleOne = item["titleOne"],
                    TitleTwo = item["titleTwo"],
                    InfoClass = item["infoClass"],
                    CodeClass = item["codeClass"],
                    LinkRef = item["linkRef"],
                    IdCourse = int.Parse(item["idCourse"]),
                    IdImageClass = int.Parse(item["idImageClass"]),
                    IdType = int.Parse(item["idType"])
                })
                .ToList();

            if (countMyClass == myClassFromJson.Count)
            {
                return;
            }

            List<MyClassTable> myClass = new List<MyClassTable>();

            foreach (var item in myClassFromJson)
            {
                if (!db.MyClassTables.Any(c => c.IdClass == item.IdClass))
                {
                    myClass.Add(new MyClassTable 
                    { 
                        IdClass = item.IdClass,
                        TitleOne = item.TitleOne,
                        TitleTwo = item.TitleTwo,
                        InfoClass = item.InfoClass,
                        CodeClass = item.CodeClass,
                        LinkRef = item.LinkRef,
                        IdCourse = item.IdCourse,
                        IdImageClass = item.IdImageClass,
                        IdType = item.IdType,
                    });
                }
            }

            db.MyClassTables.AddRange(myClass);

            Task.Run(() => db.SaveChangesAsync());
        }
    }
}
