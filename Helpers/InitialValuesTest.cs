using ProgrammingCode.Data;
using ProgrammingCode.Helpers.MyData;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Helpers
{
    public class InitialValuesTest
    {

        public async static void AddRole()
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
               await db.SaveChangesAsync();
            }
        }

        public async static void AddUser()
        {
            var db = new ApplicationContextDB();
            var query = db.AuthTables.Where(u => u.IdUser == 1).FirstOrDefault();

            if (query != null) return;
            {
                var user = new AuthTable
                {
                    IdUser = 1,
                    Name = "test",
                    UserName = "test",
                    Email = "test@gmail.com",
                    Password = BcryManager.HashPassword("test"),
                    IdRole = 2
                };

                db.AuthTables.Add(user);
               await db.SaveChangesAsync();

                var findUser = db.AuthTables.Where(u => u.IdUser == 1).FirstOrDefault();

                if (findUser != null)
                {
                    var menuAuth = new List<AuthMenuTable>
                    {
                        new AuthMenuTable { IdUser = findUser.IdUser, IdMenu = 1 },
                        new AuthMenuTable { IdUser = findUser.IdUser, IdMenu = 2 },
                        new AuthMenuTable { IdUser = findUser.IdUser, IdMenu = 3 },
                        new AuthMenuTable { IdUser = findUser.IdUser, IdMenu = 4 },
                    };

                    db.AuthMenuTables.AddRange(menuAuth);
                  await db.SaveChangesAsync();
                }
            }
        }

        public async static void AddType()
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
               await db.SaveChangesAsync();
            }
        }

        public async static void Menu()
        {
            var db = new ApplicationContextDB();

            var query = db.MenuTables.Where(menu => menu.IdMenu == 1).FirstOrDefault();

            if (query != null) return;
            {
                var menu = new List<MenuTable>()
                {
                    new MenuTable{ NameLink = "/", NameMenu = "Home"},
                    new MenuTable{ NameLink = "/about", NameMenu = "About"},
                    new MenuTable{ NameLink = "/addCourse", NameMenu = "Add Course"},
                    new MenuTable{ NameLink = "/addClass", NameMenu = "Add Class"},
                };

                db.MenuTables.AddRange(menu);
              await  db.SaveChangesAsync();
            }
        }

        public async static void AddImagesClass()
        {
            var db = new ApplicationContextDB();

            var query = db.ImagesClassTables.FirstOrDefault(ic => ic.IdImageClass == 1);

            if (query != null) return;
            else
            {
                var newImageClass = new List<ImagesClassTable>
                {
                   new ImagesClassTable
                   {   IdImageClass = 1,
                       NameImage = "imgJSI1",
                       ImageUrl = "./assets/imgJS/basic/1.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {   IdImageClass = 2,
                       NameImage = "imgJSI2",
                       ImageUrl = "./assets/imgJS/basic/2.jpg",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {   IdImageClass = 3,
                       NameImage = "imgJSI3",
                       ImageUrl = "./assets/imgJS/basic/3.jpg",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 4,
                       NameImage = "imgJSI4",
                       ImageUrl = "./assets/imgJS/basic/4.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 5,
                       NameImage = "imgJSI5",
                       ImageUrl = "./assets/imgJS/basic/5.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 6,
                       NameImage = "imgJSI6",
                       ImageUrl = "./assets/imgJS/basic/6.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 7,
                       NameImage = "imgJSI7",
                       ImageUrl = "./assets/imgJS/basic/7.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 8,
                       NameImage = "imgJSI8",
                       ImageUrl = "./assets/imgJS/basic/8.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 9,
                       NameImage = "imgJSI9",
                       ImageUrl = "./assets/imgJS/basic/9.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 10,
                       NameImage = "imgJSI10",
                       ImageUrl = "./assets/imgJS/basic/10.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 11,
                       NameImage = "imgJSI11",
                       ImageUrl = "./assets/imgJS/basic/11.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 12,
                       NameImage = "imgJSI12",
                       ImageUrl = "./assets/imgJS/basic/12.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 13,
                       NameImage = "imgJSI13",
                       ImageUrl = "./assets/imgJS/basic/13.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 14,
                       NameImage = "imgJSI14",
                       ImageUrl = "./assets/imgJS/basic/14.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 15,
                       NameImage = "imgJSI15",
                       ImageUrl = "./assets/imgJS/basic/15.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 16,
                       NameImage = "imgJSI16",
                       ImageUrl = "./assets/imgJS/basic/16.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 17,
                       NameImage = "imgJSI17",
                       ImageUrl = "./assets/imgJS/basic/17.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 18,
                       NameImage = "imgJSI18",
                       ImageUrl = "./assets/imgJS/basic/18.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 19,
                       NameImage = "imgJSI19",
                       ImageUrl = "./assets/imgJS/basic/19.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 20,
                       NameImage = "imgJSI20",
                       ImageUrl = "./assets/imgJS/basic/20.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 21,
                       NameImage = "imgJSI21",
                       ImageUrl = "./assets/imgJS/basic/21.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 22,
                       NameImage = "imgJSI22",
                       ImageUrl = "./assets/imgJS/basic/22.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 23,
                       NameImage = "imgJSI23",
                       ImageUrl = "./assets/imgJS/basic/23.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 24,
                       NameImage = "imgJSI24",
                       ImageUrl = "./assets/imgJS/basic/24.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 25,
                       NameImage = "imgJSI25",
                       ImageUrl = "./assets/imgJS/basic/25.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 26,
                       NameImage = "imgJSI26",
                       ImageUrl = "./assets/imgJS/basic/26.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 27,
                       NameImage = "imgJSI27",
                       ImageUrl = "./assets/imgJS/basic/27.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 28,
                       NameImage = "imgJSI28",
                       ImageUrl = "./assets/imgJS/basic/28.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 29,
                       NameImage = "imgJSI29",
                       ImageUrl = "./assets/imgJS/basic/29.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 30,
                       NameImage = "imgJSI30",
                       ImageUrl = "./assets/imgJS/basic/30.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 31,
                       NameImage = "imgJSI31",
                       ImageUrl = "./assets/imgJS/basic/31.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 32,
                       NameImage = "imgJSI32",
                       ImageUrl = "./assets/imgJS/basic/32.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 33,
                       NameImage = "imgJSI33",
                       ImageUrl = "./assets/imgJS/basic/33.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 34,
                       NameImage = "imgJSI34",
                       ImageUrl = "./assets/imgJS/basic/34.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 35,
                       NameImage = "imgJSI35",
                       ImageUrl = "./assets/imgJS/basic/35.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 36,
                       NameImage = "imgJSI36",
                       ImageUrl = "./assets/imgJS/basic/36.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 37,
                       NameImage = "imgJSI37",
                       ImageUrl = "./assets/imgJS/basic/37.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 38,
                       NameImage = "imgJSI38",
                       ImageUrl = "./assets/imgJS/basic/38.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 39,
                       NameImage = "imgJSI39",
                       ImageUrl = "./assets/imgJS/basic/39.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 40,
                       NameImage = "imgJSI40",
                       ImageUrl = "./assets/imgJS/basic/40.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 41,
                       NameImage = "imgJSI41",
                       ImageUrl = "./assets/imgJS/basic/41.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 42,
                       NameImage = "imgJSI42",
                       ImageUrl = "./assets/imgJS/basic/42.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 43,
                       NameImage = "imgJSI43",
                       ImageUrl = "./assets/imgJS/basic/43.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 44,
                       NameImage = "imgJSI44",
                       ImageUrl = "./assets/imgJS/basic/44.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 45,
                       NameImage = "imgJSI45",
                       ImageUrl = "./assets/imgJS/basic/45.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 46,
                       NameImage = "imgJSI46",
                       ImageUrl = "./assets/imgJS/basic/46.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 47,
                       NameImage = "imgJSI47",
                       ImageUrl = "./assets/imgJS/basic/47.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 48,
                       NameImage = "imgJSI48",
                       ImageUrl = "./assets/imgJS/basic/48.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 49,
                       NameImage = "imgJSI49",
                       ImageUrl = "./assets/imgJS/basic/49.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 50,
                       NameImage = "imgJSI50",
                       ImageUrl = "./assets/imgJS/basic/50.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 51,
                       NameImage = "imgJSI51",
                       ImageUrl = "./assets/imgJS/basic/51.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 52,
                       NameImage = "imgJSI52",
                       ImageUrl = "./assets/imgJS/basic/52.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 53,
                       NameImage = "imgJSI53",
                       ImageUrl = "./assets/imgJS/basic/53.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 54,
                       NameImage = "imgJSI54",
                       ImageUrl = "./assets/imgJS/basic/54.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 55,
                       NameImage = "imgJSI55",
                       ImageUrl = "./assets/imgJS/basic/55.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 56,
                       NameImage = "imgJSI56",
                       ImageUrl = "./assets/imgJS/basic/56.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 57,
                       NameImage = "imgJSI57",
                       ImageUrl = "./assets/imgJS/basic/57.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 58,
                       NameImage = "imgJSI58",
                       ImageUrl = "./assets/imgJS/basic/58.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 59,
                       NameImage = "imgJSI59",
                       ImageUrl = "./assets/imgJS/basic/59.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 60,
                       NameImage = "imgJSI60",
                       ImageUrl = "./assets/imgJS/basic/60.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 61,
                       NameImage = "imgJSI61",
                       ImageUrl = "./assets/imgJS/basic/61.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 62,
                       NameImage = "imgJSI62",
                       ImageUrl = "./assets/imgJS/basic/62.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 63,
                       NameImage = "imgJSI63",
                       ImageUrl = "./assets/imgJS/basic/63.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 64,
                       NameImage = "imgJSI64",
                       ImageUrl = "./assets/imgJS/basic/64.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 65,
                       NameImage = "imgJSI65",
                       ImageUrl = "./assets/imgJS/basic/65.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 66,
                       NameImage = "imgJSI66",
                       ImageUrl = "./assets/imgJS/basic/66.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 67,
                       NameImage = "imgJSI67",
                       ImageUrl = "./assets/imgJS/basic/67.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 68,
                       NameImage = "imgJSI68",
                       ImageUrl = "./assets/imgJS/basic/68.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 69,
                       NameImage = "imgJSI69",
                       ImageUrl = "./assets/imgJS/basic/69.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 70,
                       NameImage = "imgJSI70",
                       ImageUrl = "./assets/imgJS/basic/70.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 71,
                       NameImage = "imgJSI71",
                       ImageUrl = "./assets/imgJS/basic/71.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 72,
                       NameImage = "imgJSI72",
                       ImageUrl = "./assets/imgJS/basic/72.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 73,
                       NameImage = "imgJSI73",
                       ImageUrl = "./assets/imgJS/basic/73.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 74,
                       NameImage = "imgJSI74",
                       ImageUrl = "./assets/imgJS/basic/74.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 75,
                       NameImage = "imgJSI75",
                       ImageUrl = "./assets/imgJS/basic/75.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 76,
                       NameImage = "imgJSI76",
                       ImageUrl = "./assets/imgJS/basic/76.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 77,
                       NameImage = "imgJSI77",
                       ImageUrl = "./assets/imgJS/basic/77.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 78,
                       NameImage = "imgJSI78",
                       ImageUrl = "./assets/imgJS/basic/78.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 79,
                       NameImage = "imgJSI79",
                       ImageUrl = "./assets/imgJS/basic/79.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 80,
                       NameImage = "imgJSI80",
                       ImageUrl = "./assets/imgJS/basic/80.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 81,
                       NameImage = "imgJSI81",
                       ImageUrl = "./assets/imgJS/basic/81.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 82,
                       NameImage = "imgJSI82",
                       ImageUrl = "./assets/imgJS/basic/82.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 83,
                       NameImage = "imgJSI83",
                       ImageUrl = "./assets/imgJS/basic/83.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 84,
                       NameImage = "imgJSI84",
                       ImageUrl = "./assets/imgJS/basic/84.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 85,
                       NameImage = "imgJSI85",
                       ImageUrl = "./assets/imgJS/basic/85.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 86,
                       NameImage = "imgJSI86",
                       ImageUrl = "./assets/imgJS/basic/86.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 87,
                       NameImage = "imgJSI87",
                       ImageUrl = "./assets/imgJS/basic/87.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 88,
                       NameImage = "imgJSI88",
                       ImageUrl = "./assets/imgJS/basic/88.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 89,
                       NameImage = "imgJSI89",
                       ImageUrl = "./assets/imgJS/basic/89.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 90,
                       NameImage = "imgJSI90",
                       ImageUrl = "./assets/imgJS/basic/90.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 91,
                       NameImage = "imgC#I1",
                       ImageUrl = "./assets/imgCSharp/basic/1.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 92,
                       NameImage = "imgC#I2",
                       ImageUrl = "./assets/imgCSharp/basic/2.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 93,
                       NameImage = "imgC#I3",
                       ImageUrl = "./assets/imgCSharp/basic/3.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 94,
                       NameImage = "imgC#I4",
                       ImageUrl = "./assets/imgCSharp/basic/4.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 95,
                       NameImage = "imgC#I5",
                       ImageUrl = "./assets/imgCSharp/basic/5.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 96,
                       NameImage = "imgC#I6",
                       ImageUrl = "./assets/imgCSharp/basic/6.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 97,
                       NameImage = "imgC#I7",
                       ImageUrl = "./assets/imgCSharp/basic/7.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 98,
                       NameImage = "imgC#I8",
                       ImageUrl = "./assets/imgCSharp/basic/8.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 99,
                       NameImage = "imgC#I9",
                       ImageUrl = "./assets/imgCSharp/basic/9.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 100,
                       NameImage = "imgC#I10",
                       ImageUrl = "./assets/imgCSharp/basic/10.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 101,
                       NameImage = "imgC#I11",
                       ImageUrl = "./assets/imgCSharp/basic/11.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 102,
                       NameImage = "imgC#I12",
                       ImageUrl = "./assets/imgCSharp/basic/12.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 103,
                       NameImage = "imgC#I13",
                       ImageUrl = "./assets/imgCSharp/basic/13.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 104,
                       NameImage = "imgC#I14",
                       ImageUrl = "./assets/imgCSharp/basic/14.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 105,
                       NameImage = "imgC#I15",
                       ImageUrl = "./assets/imgCSharp/basic/15.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 106,
                       NameImage = "imgC#I16",
                       ImageUrl = "./assets/imgCSharp/basic/16.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 107,
                       NameImage = "imgC#I17",
                       ImageUrl = "./assets/imgCSharp/basic/17.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 108,
                       NameImage = "imgC#I18",
                       ImageUrl = "./assets/imgCSharp/basic/18.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 109,
                       NameImage = "imgC#I19",
                       ImageUrl = "./assets/imgCSharp/basic/19.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 110,
                       NameImage = "imgC#I20",
                       ImageUrl = "./assets/imgCSharp/basic/20.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 111,
                       NameImage = "imgC#I21",
                       ImageUrl = "./assets/imgCSharp/basic/21.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 112,
                       NameImage = "imgC#I22",
                       ImageUrl = "./assets/imgCSharp/basic/22.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 113,
                       NameImage = "imgC#I23",
                       ImageUrl = "./assets/imgCSharp/basic/23.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 114,
                       NameImage = "imgC#I24",
                       ImageUrl = "./assets/imgCSharp/basic/24.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 115,
                       NameImage = "imgC#I25",
                       ImageUrl = "./assets/imgCSharp/basic/25.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 116,
                       NameImage = "imgC#I26",
                       ImageUrl = "./assets/imgCSharp/basic/26.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 117,
                       NameImage = "imgC#I27",
                       ImageUrl = "./assets/imgCSharp/basic/27.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 118,
                       NameImage = "imgC#I28",
                       ImageUrl = "./assets/imgCSharp/basic/28.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 119,
                       NameImage = "imgC#I29",
                       ImageUrl = "./assets/imgCSharp/basic/29.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 120,
                       NameImage = "imgC#I30",
                       ImageUrl = "./assets/imgCSharp/basic/30.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 121,
                       NameImage = "imgC#I31",
                       ImageUrl = "./assets/imgCSharp/basic/31.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 122,
                       NameImage = "imgC#I32",
                       ImageUrl = "./assets/imgCSharp/basic/32.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 123,
                       NameImage = "imgC#I33",
                       ImageUrl = "./assets/imgCSharp/basic/33.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 124,
                       NameImage = "imgC#I34",
                       ImageUrl = "./assets/imgCSharp/basic/34.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 125,
                       NameImage = "imgC#I35",
                       ImageUrl = "./assets/imgCSharp/basic/35.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 126,
                       NameImage = "imgC#I36",
                       ImageUrl = "./assets/imgCSharp/basic/36.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 127,
                       NameImage = "imgC#I37",
                       ImageUrl = "./assets/imgCSharp/basic/37.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 128,
                       NameImage = "imgC#I38",
                       ImageUrl = "./assets/imgCSharp/basic/38.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 129,
                       NameImage = "imgC#I39",
                       ImageUrl = "./assets/imgCSharp/basic/39.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 130,
                       NameImage = "imgC#I40",
                       ImageUrl = "./assets/imgCSharp/basic/40.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 131,
                       NameImage = "imgC#I41",
                       ImageUrl = "./assets/imgCSharp/basic/41.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 132,
                       NameImage = "imgC#I42",
                       ImageUrl = "./assets/imgCSharp/basic/42.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 133,
                       NameImage = "imgC#I43",
                       ImageUrl = "./assets/imgCSharp/basic/43.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 134,
                       NameImage = "imgC#I44",
                       ImageUrl = "./assets/imgCSharp/basic/44.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 135,
                       NameImage = "imgC#I45",
                       ImageUrl = "./assets/imgCSharp/basic/45.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 136,
                       NameImage = "imgC#I46",
                       ImageUrl = "./assets/imgCSharp/basic/46.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 137,
                       NameImage = "imgC#I47",
                       ImageUrl = "./assets/imgCSharp/basic/47.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 138,
                       NameImage = "imgC#I48",
                       ImageUrl = "./assets/imgCSharp/basic/48.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 139,
                       NameImage = "imgC#I49",
                       ImageUrl = "./assets/imgCSharp/basic/49.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                   new ImagesClassTable
                   {
                       IdImageClass = 140,
                       NameImage = "imgC#I50",
                       ImageUrl = "./assets/imgCSharp/basic/50.png",
                       RefImage = "",
                       ImageBase64 = ""
                   },
                };
                db.ImagesClassTables.AddRange(newImageClass);
               await db.SaveChangesAsync();
            }
        }

        public async static void AddImagesCourse()
        {
            var db = new ApplicationContextDB();

            var query = db.CourseTables.FirstOrDefault(c => c.IdCourse == 1);

            if (query != null) return;
            else
            {
                var newImageCourse = new List<ImagesCoursesTable>
                {
                    new ImagesCoursesTable
                    {   IdImageCourse = 1,
                        NameImage = "imgJavaScript",
                        ImageUrl = "",
                        RefImage = Guid.NewGuid().ToString().ToUpper(),
                        ImageBase64 = MyDataImagesCourse.imgJavaScript,
                    },
                    new ImagesCoursesTable
                    {   IdImageCourse = 2,
                        NameImage = "imgC#",
                        ImageUrl = "",
                        RefImage = Guid.NewGuid().ToString().ToUpper(),
                        ImageBase64 = MyDataImagesCourse.imgCSharp,
                    },
                };
                db.ImagesCoursesTables.AddRange(newImageCourse);
              await db.SaveChangesAsync();
            }
        }

        public async static void AddCourse()
        {
            var db = new ApplicationContextDB();

            var query = db.CourseTables.FirstOrDefault(c => c.IdCourse == 1);

            if (query != null) return;
            else
            {
                var newCourse = new List<CourseTable>
                {
                    new CourseTable
                    {
                        IdCourse = 1,
                        Name = "JAVASCRIPT I",
                        IdType = 1,
                        IdImageCourse = 1,
                    },
                    new CourseTable
                    {
                        IdCourse = 2,
                        Name = "C# I",
                        IdType = 1,
                        IdImageCourse = 2,
                    },
                };
                db.CourseTables.AddRange(newCourse);
              await  db.SaveChangesAsync();
            }
        }

        public async static void AddMyClass()
        {
            var db = new ApplicationContextDB();

            var query = db.MyClassTables.FirstOrDefault(c => c.IdClass == 1);

            if (query != null) return;
            else
            {
                var newMyClass = new List<MyClassTable>
                {
                    new MyClassTable
                    {
                        IdClass = 1,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 1,
                        TitleOne = "1. JavaScript",
                        TitleTwo = "JavaScript (/ˈdʒɑːvəskrɪpt/), often abbreviated as JS, is a programming language and core technology of the World Wide Web, alongside HTML and CSS. As of 2023, 98.7% of websites use JavaScript on the client side for webpage behavior,  often incorporating third-party libraries. All major web browsers have a dedicated JavaScript engine to execute the code on users' devices.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://en.wikipedia.org/wiki/JavaScript",
                    },
                    new MyClassTable
                    {
                        IdClass = 2,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 2,
                        TitleOne = "2. History",
                        TitleTwo = "Creation at Netscape",
                        InfoClass = "The first popular web browser with a graphical user interface, Mosaic, was released in 1993. Accessible to non-technical people, it played a prominent role in the rapid growth of the nascent World Wide Web  The lead developers of Mosaic then founded the Netscape corporation, which released a more polished browser, Netscape Navigator, in 1994. This quickly became the most-used.",
                        CodeClass = "",
                        LinkRef = "https://en.wikipedia.org/wiki/Netscape_Navigator",
                    },
                    new MyClassTable
                    {
                        IdClass = 3,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 3,
                        TitleOne = "3. Variables in JavaScript",
                        TitleTwo = "A variable in JavaScript is a named storage location that holds data values. It is a symbolic name (an identifier) for a value that can be changed during the execution of a program. Variables are fundamental to programming as they allow developers to store and manipulate data dynamically.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 4,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 4,
                        TitleOne = "4. Variable var",
                        TitleTwo = "Variables declared with var are function-scoped. This means they are only accessible within the function where they are declared.",
                        InfoClass = "var variables are hoisted to the top of their scope during the execution phase, which means you can use them before they are declared in the code.",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/es/docs/Web/JavaScript/Reference/Statements/var",
                    },
                    new MyClassTable
                    {
                        IdClass = 5,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 5,
                        TitleOne = "5. Variable let",
                        TitleTwo = "Variables declared with let are block-scoped. They are only accessible within the block (enclosed by curly braces) where they are defined.",
                        InfoClass = "let variables are not hoisted to the top of their block, and attempting to access them before declaration results in a ReferenceError.",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/let",
                    },
                    new MyClassTable
                    {
                        IdClass = 6,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 6,
                        TitleOne = "6. Variable const",
                        TitleTwo = "The const declaration declares block-scoped local variables. The value of a constant can't be changed through reassignment using the assignment operator, but if a constant is an object, its properties can be added, updated, or removed.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/const",
                    },
                    new MyClassTable
                    {
                        IdClass = 7,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 7,
                        TitleOne = "7. Data Types in JavaScript",
                        TitleTwo = "JavaScript is a dynamically-typed language, meaning that variables are not bound to a specific data type at the time of declaration. Instead, JavaScript has several primitive data types and one complex data type. Here are the main data types in JavaScript.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 8,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 8,
                        TitleOne = "8. String",
                        TitleTwo = "The String object is used to represent and manipulate a sequence of characters. nStrings are useful for holding data that can be represented in text form. Some of the most-used operations on strings are to check their length, to build and concatenate them using the + and += string operators, checking for the existence or location of substrings with the indexOf() method, or extracting substrings with the substring() method.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String",
                    },
                    new MyClassTable
                    {
                        IdClass = 9,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 9,
                        TitleOne = "9. Number",
                        TitleTwo = "Number values represent floating-point numbers like 37 or -9.25 The Number constructor contains constants and methods for working with numbers. Values ofother types can be converted to numbers using the Number() function.\\nNumbers are most commonly expressed in literal forms like 255 or 3.14159. The lexical grammar contains a more detailed reference",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Number",
                    },
                    new MyClassTable
                    {
                        IdClass = 10,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 10,
                        TitleOne = "10. CharAt",
                        TitleTwo = "In JavaScript, there is no specific char  type. Characters are typically represented as strings, which are sequences of characters. You can access individual characters in a string using indexing.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/es/docs/Web/JavaScript/Reference/Global_Objects/String/charAt",
                    },
                    new MyClassTable
                    {
                        IdClass = 11,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 11,
                        TitleOne = "11. Boolean",
                        TitleTwo = "The boolean data type represents two values: true or false. It is commonly used for conditions and logical operations in JavaScript.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Boolean",
                    },
                    new MyClassTable
                    {
                        IdClass = 12,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 12,
                        TitleOne = "12. Decimal",
                        TitleTwo = "In JavaScript, numbers include both integers and floating-point numbers. There isn't a specific decimal type. Numbers are used for arithmetic operations and numeric calculations.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Number",
                    },
                    new MyClassTable
                    {
                        IdClass = 13,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 13,
                        TitleOne = "13. Array",
                        TitleTwo = "Arrays are used to store multiple values in a single variable. Elements in an array can be of any data type, and they are accessed using numeric indices.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array",
                    },
                    new MyClassTable
                    {
                        IdClass = 14,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 14,
                        TitleOne = "14. Object",
                        TitleTwo = "Objects are complex data types that store key-value pairs. Each key is a string, and values can be of any data type, including other objects. Objects are used to represent more structured data.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object",
                    },
                    new MyClassTable
                    {
                        IdClass = 15,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 15,
                        TitleOne = "15. Console.Log",
                        TitleTwo = "console.log is a method in JavaScript used for logging information to the console. It's commonly used for debugging and displaying output in the browser's developer console.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "https://developer.mozilla.org/en-US/docs/Web/API/console/log_static",
                    },
                    new MyClassTable
                    {
                        IdClass = 16,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 16,
                        TitleOne = "16. Sum (+)",
                        TitleTwo = "The addition operator (+) adds two values together.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 17,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 17,
                        TitleOne = "17. Subtraction (-)",
                        TitleTwo = "The subtraction operator (-) subtracts the right operand from the left operand.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 18,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 18,
                        TitleOne = "18. Multiplication (*)",
                        TitleTwo = "The multiplication operator (*) multiplies two values.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 19,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 19,
                        TitleOne = "19. Division (/)",
                        TitleTwo = "The division operator (/) divides the left operand by the right operand.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 20,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 20,
                        TitleOne = "20. Control Structures",
                        TitleTwo = "Control structures in JavaScript are elements that determine the flow of program execution. They enable decision-making based on conditions and the repetition of certain actions through loops. The main control structures include conditionals (if, else, else if, switch)",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },

                      new MyClassTable
                    {
                        IdClass = 21,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 21,
                        TitleOne = "21. If - Else",
                        TitleTwo = "The if-else statement is used for conditional execution of code. If the condition inside the if statement evaluates to true, the code inside the block is executed. Otherwise, the code inside the else block (if present) is executed.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 22,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 22,
                        TitleOne = "22. Else - If",
                        TitleTwo = "In JavaScript, else if is part of the if statement and is used to provide an alternative condition to be checked if the initial if condition evaluates to false. The else if statement allows you to check multiple conditions sequentially.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 23,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 23,
                        TitleOne = "23. Operator Ternary",
                        TitleTwo = "The ternary operator, also known as the conditional operator, is a shorthand way to express conditional logic in JavaScript. It has the following syntax.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 24,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 24,
                        TitleOne = "24. Switch",
                        TitleTwo = "The switch statement in JavaScript is used to perform different actions based on different conditions. It provides a cleaner and more concise alternative to a series of if-else if statements when you need to compare a variable against multiple possible values.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 25,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 25,
                        TitleOne = "25. Logical Operator",
                        TitleTwo = "",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "In JavaScript, a logical operator is a symbol or set of symbols that perform logical operations on boolean values (true or false). These operators are essential for constructing logical expressions and controlling the flow of execution in programs. The primary logical operators in JavaScript include.",
                    },
                    new MyClassTable
                    {
                        IdClass = 26,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 26,
                        TitleOne = "26. Comparison Operator",
                        TitleTwo = "In JavaScript, comparison operators are symbols or sets of symbols used to compare two values and produce a boolean result (true or false) based on the relationship between those values. These operators are essential for establishing conditions and making decisions in programs. Here are some of the most common comparison operators in JavaScript.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 27,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 27,
                        TitleOne = "27. Assignment Operator",
                        TitleTwo = "In JavaScript, the assignment operator is used to assign a value to a variable. The most common assignment operator is the equals sign (=). Here's how it works.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 28,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 28,
                        TitleOne = "28. Loops in JavaScript",
                        TitleTwo = "In programming, loops are control structures that allow the repetition of a block of code multiple times until a specific condition is met. Loops are fundamental for automating repetitive tasks and processing sets of data. (for for...in, for...of,  foreach, while and  do while).",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 29,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 29,
                        TitleOne = "29. Cycle for",
                        TitleTwo = "The for statement in JavaScript is a loop control structure that repeats a block of code as long as a specified condition is true. It consists of an initialization, a condition, and an increment (or decrement) expression.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 30,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 30,
                        TitleOne = "30. Cycle for...in",
                        TitleTwo = "The for...in statement is used to iterate over the enumerable properties of an object. It enumerates the properties in arbitrary order, including those inherited from the object's prototype chain",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 31,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 31,
                        TitleOne = "31. Cycle for...of",
                        TitleTwo = "The for...of statement is used to iterate over iterable objects, such as arrays, strings, maps, sets, etc. It provides a concise syntax for iterating without having to deal with index variables.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 32,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 32,
                        TitleOne = "32. Cycle forEach",
                        TitleTwo = "The forEach method is a higher-order function available for arrays in JavaScript. It executes a provided function once for each element in the array, in ascending order.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 33,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 33,
                        TitleOne = "33. Break",
                        TitleTwo = "The break statement is used to terminate the execution of a loop prematurely. It is commonly used in for, while, and do-while loops to exit the loop when a certain condition is met, without completing the remaining iterations.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 34,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 34,
                        TitleOne = "34. Cycle While",
                        TitleTwo = "The while statement is a loop control structure that repeatedly executes a block of code as long as a specified condition evaluates to true. The condition is checked before the execution of the block.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 35,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 35,
                        TitleOne = "35. Cycle Do-While",
                        TitleTwo = "The do-while statement is a loop control structure that is similar to the while loop. However, in a do-while loop, the condition is evaluated after the execution of the block, meaning that the block is guaranteed to execute at least once.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 36,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 36,
                        TitleOne = "36. Function in JavaScripts",
                        TitleTwo = "A function in JavaScript is a reusable block of code that performs a specific task. It can take zero or more parameters and may return a result. The declaration of a function is done using the function keyword.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 37,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 37,
                        TitleOne = "37. Function with Parameters",
                        TitleTwo = "A function with parameters is a function that accepts values (parameters) which are used within the body of the function. Parameters allow the function to be more flexible and work with different values on each invocation.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 38,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 38,
                        TitleOne = "38. Arrow Function",
                        TitleTwo = "An arrow function is a more concise way to write functions in JavaScript. It uses the arrow => syntax and, in many cases, provides a shorter and clearer syntax compared to traditional functions.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 39,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 39,
                        TitleOne = "39. Arrow Function with Parameters",
                        TitleTwo = "An arrow function with parameters is simply an arrow function that accepts one or more parameters. It provides a more compact way of defining functions, especially when the function is brief and does not require an extensive block statement.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 40,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 40,
                        TitleOne = "40. Method Array Pop",
                        TitleTwo = "The pop method is an array method in JavaScript that removes the last element from an array and returns that element. The length of the array is also decreased by 1.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },


                      new MyClassTable
                    {
                        IdClass = 41,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 41,
                        TitleOne = "41. Method Array Push",
                        TitleTwo = "The push method is an array method in JavaScript that adds one or more elements to the end of an array and returns the new length of the array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 42,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 42,
                        TitleOne = "42. Method Array Shift",
                        TitleTwo = "The shift method is an array method in JavaScript that removes the first element from an array and returns that element. The length of the array is also decreased by 1.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 43,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 43,
                        TitleOne = "43. Method Array Unshift",
                        TitleTwo = "The unshift method is an array method in JavaScript that adds one or more elements to the beginning of an array and returns the new length of the array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 44,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 44,
                        TitleOne = "44. Method Array  Length",
                        TitleTwo = "The length property of an array returns the number of elements in the array. It represents the length or size of the array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 45,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 45,
                        TitleOne = "45. Method Array  Index",
                        TitleTwo = "In the context of arrays, there isn't a direct method called index. However, if you are referring to accessing elements by index, it involves using square brackets ([]) notation. For example, array[0] accesses the element at index 0.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 46,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 46,
                        TitleOne = "46. Method Array   Splice",
                        TitleTwo = "The splice method is an array method in JavaScript that changes the contents of an array by removing or replacing existing elements and/or adding new elements in place.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 47,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 47,
                        TitleOne = "47. Method Array   Slice",
                        TitleTwo = "The slice method is an array method in JavaScript that returns a shallow copy of a portion of an array into a new array. It does not modify the original array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 48,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 48,
                        TitleOne = "48. Method Array  Concat",
                        TitleTwo = "The concat method is an array method in JavaScript that combines two or more arrays, creating a new array containing the elements of all the arrays.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 49,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 49,
                        TitleOne = "49. Method Array  Includes",
                        TitleTwo = "The includes method is an array method in JavaScript that determines whether an array includes a certain value among its elements, returning true or false as appropriate.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 50,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 50,
                        TitleOne = "50. Method Array IndexOf",
                        TitleTwo = "The indexOf method is an array method in JavaScript that returns the first index at which a specified element is found in the array. If the element is not present, it returns -1.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 51,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 51,
                        TitleOne = "51. Method Array Join",
                        TitleTwo = "The join method is an array method in JavaScript that creates and returns a new string by concatenating all the elements in an array, separated by a specified separator or a comma if no separator is provided.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 52,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 52,
                        TitleOne = "52. Method Array Reverse",
                        TitleTwo = "The reverse method is an array method in JavaScript that reverses the order of the elements in an array. The first element becomes the last, and the last element becomes the first.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 53,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 53,
                        TitleOne = "53. Method Array Sort",
                        TitleTwo = "The sort method is an array method in JavaScript that sorts the elements of an array in place, meaning it modifies the array. By default, it sorts the elements as strings.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 54,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 54,
                        TitleOne = "54. Method Array Every",
                        TitleTwo = "The every method is an array method in JavaScript that tests whether all elements in the array pass the provided function. It returns true if the callback function returns true for every element; otherwise, it returns false.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 55,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 55,
                        TitleOne = "55. Method Array Find",
                        TitleTwo = "The find method is an array method in JavaScript that returns the first element in the array that satisfies the provided testing function. Otherwise, it returns undefined.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 56,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 56,
                        TitleOne = "56. Method Array Filter",
                        TitleTwo = "The filter method is an array method in JavaScript that creates a new array with all elements that pass the test implemented by the provided function.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 57,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 57,
                        TitleOne = "57. Method Array  Map",
                        TitleTwo = "The map method is an array method in JavaScript that creates a new array with the results of calling a provided function on every element in the array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 58,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 58,
                        TitleOne = "58. Method Array Reduce",
                        TitleTwo = "The reduce method is an array method in JavaScript that applies a function against an accumulator and each element in the array (from left to right) to reduce it to a single value.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 59,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 59,
                        TitleOne = "59. Method Array Some",
                        TitleTwo = "The some method is an array method in JavaScript that tests whether at least one element in the array passes the test implemented by the provided function. It returns true if at least one element passes; otherwise, it returns false.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 60,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 60,
                        TitleOne = "60. Method Array Flat",
                        TitleTwo = "The flat method is an array method in JavaScript that creates a new array with all sub-array elements concatenated into it recursively up to the specified depth.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },


                      new MyClassTable
                    {
                        IdClass = 61,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 61,
                        TitleOne = "61. Method Array ForEach",
                        TitleTwo = "An array in JavaScript is a data structure that allows the storage of multiple values in a single variable. The forEach method is an array method in JavaScript that provides an easy way to iterate through each element of an array. It executes a provided function once for each array element, allowing you to perform actions or operations on each element individually.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 62,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 62,
                        TitleOne = "62. Spread Operator in Array",
                        TitleTwo = "In JavaScript, the spread operator (...) is used in the context of an array to expand or spread its elements. When applied to an array, it can be used to create a shallow copy of the array, concatenate arrays, or pass array elements as arguments to a function. The spread operator essentially unpacks the elements of an array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 63,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 63,
                        TitleOne = "63. Spread Operator in Object",
                        TitleTwo = "In JavaScript, the spread operator (...) can also be used in the context of an object. When applied to an object, it is used to create a shallow copy of the object or merge multiple objects into a new one. The spread operator for objects provides a concise way to duplicate or combine key-value pairs.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 64,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 64,
                        TitleOne = "64. Object Key",
                        TitleTwo = "In JavaScript, an object key refers to the property name associated with a value within an object. Object keys are strings or symbols and are used to uniquely identify and access the values stored in an object.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 65,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 65,
                        TitleOne = "65. Method Object Value",
                        TitleTwo = "In JavaScript, an object value refers to the data or information associated with a specific property within an object. Each property of an object has a key-value pair, and the value is the actual data or content stored under that property.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 66,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 66,
                        TitleOne = "66. Method  Object Keys",
                        TitleTwo = "The Object.values method in JavaScript is a built-in method that returns an array containing the values of an object. It extracts and provides an array of all enumerable property values from the given object.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 67,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 67,
                        TitleOne = "67. Method  Object  Values",
                        TitleTwo = "The Object.values method in JavaScript is a built-in method that returns an array containing the values of an object. It extracts and provides an array of all enumerable property values from the given object.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 68,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 68,
                        TitleOne = "68. Method  Object Entries",
                        TitleTwo = "In JavaScript, Object.entries is a built-in method that returns an array of a given object's own enumerable string-keyed property [key, value] pairs.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 69,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 69,
                        TitleOne = "69.  Method  Object Assign",
                        TitleTwo = "Object.assign is a built-in method in JavaScript that is used to copy the values of all enumerable own properties from one or more source objects to a target object.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 70,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 70,
                        TitleOne = "70. Method Object.hasOwnProperty",
                        TitleTwo = "The hasOwnProperty method is a built-in method in JavaScript that is used to check whether an object has a specific property as its own property. It returns a boolean value.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 71,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 71,
                        TitleOne = "71. Method  Object.freeze",
                        TitleTwo = "The Object.freeze method is a built-in method in JavaScript that is used to freeze an object. A frozen object cannot have new properties added to it, and existing properties cannot be removed or modified.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 72,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 72,
                        TitleOne = "72. Method  Add Property",
                        TitleTwo = "Adding a property to an object in JavaScript involves assigning a new key-value pair to the object. This can be done using the dot notation (object.newProperty = value) or square bracket notation (object['newProperty'] = value).",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 73,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 73,
                        TitleOne = "73. Method  Delete Property",
                        TitleTwo = "The delete operator in JavaScript can be used to remove a property from an object. It takes an object and a property name as arguments and removes that property from the object if it exists.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 74,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 74,
                        TitleOne = "74. Method  Copy Object",
                        TitleTwo = "Creating a copy of an object with an additional property involves creating a new object and copying all the properties from the original object to the new one. Then, the new property is added.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 75,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 75,
                        TitleOne = "75. Class",
                        TitleTwo = "In JavaScript, a class is a blueprint for creating objects with shared properties and methods. It is a template or a prototype that defines the structure and behavior of objects. Classes are introduced in ECMAScript 6 (ES6) and provide a more organized and syntactic way to create objects and handle inheritance.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 76,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 76,
                        TitleOne = "76. Method (in a Class)",
                        TitleTwo = "In the context of a class, a method is a function that is associated with an object created from that class. Methods define the behavior or actions that instances of the class can perform. They are defined within the class and can access and modify the object's state.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 77,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 77,
                        TitleOne = "77. Inheritance (in a Class)",
                        TitleTwo = "Inheritance is a concept in object-oriented programming (OOP) that allows a class (subclass or child class) to inherit properties and methods from another class (superclass or parent class). It promotes code reuse and the creation of a hierarchical structure in which a subclass can extend or override the functionalities of a superclass.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 78,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 78,
                        TitleOne = "78. Static Method (in a Class)",
                        TitleTwo = "A static method in a class is a method that belongs to the class itself rather than instances of the class. It is invoked on the class rather than on an object created from the class. Static methods are defined using the static keyword and can be called directly on the class without creating an instance.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 79,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 79,
                        TitleOne = "79. Class Getter and Setter",
                        TitleTwo = "In a JavaScript class, a getter is a method used to retrieve the value of a class's property, and a setter is a method used to modify or set the value of a class's property. Getters and setters provide controlled access to the properties of an object, allowing additional logic to be executed during property access or modification.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 80,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 80,
                        TitleOne = "80. Class Private Field",
                        TitleTwo = "In JavaScript, a class private field is a field marked with a hash (#). It is a private variable within a class that is not accessible outside the class. Private fields provide encapsulation, allowing class members to be hidden and preventing direct access from external code.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },


                      new MyClassTable
                    {
                        IdClass = 81,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 81,
                        TitleOne = "81. Class Private Method",
                        TitleTwo = "A class private method in JavaScript is a method marked with a hash (#). It is a method within a class that is not accessible outside the class. Private methods are used for encapsulation, allowing certain functionalities to be kept internal to the class.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 82,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 82,
                        TitleOne = "82. Typeof Operator",
                        TitleTwo = "When using the typeof operator on a variable with the value null, it returns 'object'. On the other hand, using typeof on a variable with the value undefined returns 'undefined'.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 83,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 83,
                        TitleOne = "83. Null",
                        TitleTwo = "In JavaScript, null is a primitive value representing the intentional absence of any object value. It is often used to explicitly indicate that a variable or object property has no assigned value. It is a way to represent the absence of an object where an object is expected.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 84,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 84,
                        TitleOne = "84. Undefined",
                        TitleTwo = "In JavaScript, undefined is a primitive value that is automatically assigned to variables that have been declared but have not been initialized with a value. It is also the default return value of a function that does not explicitly return anything.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 85,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 85,
                        TitleOne = "85. try-catch",
                        TitleTwo = "try-catch is a code block in many programming languages, including C#, used to handle exceptions. Code that might generate an exception is placed within the try block, and any exception that occurs during execution is caught and handled in the catch block. This allows the program to respond in a controlled way to exceptional situations.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 86,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 86,
                        TitleOne = "86. throw",
                        TitleTwo = "throw is a keyword used to manually throw an exception in a program. When a condition requiring an exceptional response is encountered, throw can be used to generate an exception, allowing the surrounding code to handle it through a try-catch block.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 87,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 87,
                        TitleOne = "87. async and await",
                        TitleTwo = "async and await are keywords in C# (and other programming languages) used in the context of asynchronous programming. async is placed in the declaration of a method to indicate that the method can perform asynchronous operations, and await is used within async methods to wait for the completion of an asynchronous operation without blocking the main thread.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 88,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 88,
                        TitleOne = "88. arrow function async and await",
                        TitleTwo = "In JavaScript, arrow functions are a concise way to write functions. async and await are used in the context of asynchronous programming in JavaScript. When a function is declared as async, it indicates that the function will return a promise. The await operator is used inside async functions to wait for the resolution of a promise before continuing with the code execution.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 89,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 89,
                        TitleOne = "89. promise",
                        TitleTwo = "A Promise is an object in JavaScript that represents the eventual completion or failure of an asynchronous operation and its resulting value. Promises are commonly used to manage asynchronous operations in a more structured and readable manner.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 90,
                        IdCourse = 1,
                        IdType = 1,
                        IdImageClass = 90,
                        TitleOne = "90. promise then",
                        TitleTwo = ".then() is a method associated with promises in JavaScript. It is used to handle the successful resolution of a promise. When a promise is successfully resolved, the code inside .then() is executed, allowing controlled handling of the results of the asynchronous operation.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 91,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 91,
                        TitleOne = "1. C Sharp (programming language)",
                        TitleTwo = "C# (/ˌsiː ˈʃɑːrp/ see SHARP) is a general-purpose high-level programming language supporting multiple paradigms. C# encompasses static typing strong typing, lexically scoped, imperative, declarative, functional, generic object-oriented (class-based), and component-oriented programming disciplines. \",\r\n    \"infoClass\": \"The C# programming language was designed by Anders Hejlsberg from Microsoft in 2000 and was later approved as an international standard by Ecma (ECMA-334) in 2002 and ISO/IEC (ISO/IEC 23270 and 20619[c]) in 2003. Microsoft introduced C# along with .NET Framework and Visual Studio, both of which were closed-source. At the time, Microsoft had no open-source products. Four years later, in 2004, a free and open-source project called Mono began, providing a cross-platform compiler and runtime environment for the C# programming language. A decade later, Microsoft released Visual Studio Code (code editor), Roslyn (compiler), and the unified .NET platform (software framework), all of which support C# and are free, open-source, and cross-platform. Mono also joined Microsoft but was not merged into .NET. As of November 2023, the most recent stable version of the language is C# 12.0, which was released in 2023 in .NET 8.0. ",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 92,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 92,
                        TitleOne = "2. Install Visual Studio Code",
                        TitleTwo = "Visual Studio Code (VSCode) is a free and open-source source code editor developed by Microsoft. Here's some information about Visual Studio Code.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 93,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 93,
                        TitleOne = "3. Install .NET Core SDK",
                        TitleTwo = "It seems like you might be referring to the .NET SDK (Software Development Kit), which is a set of tools and libraries for developing applications on the .NET platform. Here's some information about the .NET SDK.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 94,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 94,
                        TitleOne = "4. Hello World",
                        TitleTwo = "Hello, World! is a simple program that is often used as the first example when learning a new programming language. It typically consists of a program that outputs the text \\\"Hello, World!\\\" to the console or other output medium.The purpose of the Hello, World! program is to demonstrate the basic syntax of a programming language and ensure that the development environment is set up correctly.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 95,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 95,
                        TitleOne = "5. Program.cs",
                        TitleTwo = "Program.cs is a common filename for the main program file in a C# project. It typically contains the Main method, which is the entry point for the program. The Main method is where the program begins execution. It can contain the code that will be executed when the program is run.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 96,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 96,
                        TitleOne = "6. Command dotnet run",
                        TitleTwo = "The dotnet run command is used in the command line or terminal to build and run a .NET project. It is commonly used in the directory where the C# project is located. When you run dotnet run, it compiles the C# code, resolves dependencies.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 97,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 97,
                        TitleOne = "7. Var variable",
                        TitleTwo = "The var keyword in C# is used for implicitly typed local variables.",
                        InfoClass = "The type of the variable is determined by the compiler based on the assigned value. Once a type is assigned, it cannot be changed.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 98,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 98,
                        TitleOne = "8. Dynamic Variable (dynamic)",
                        TitleTwo = "The dynamic keyword allows you to store any type of value, and the type is resolved at runtime. It provides flexibility but sacrifices compile-time type checking.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 99,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 99,
                        TitleOne = "9. Object Variable (object)",
                        TitleTwo = "The object type is a base type for all other types in C#.",
                        InfoClass = "It can store any type of value but requires explicit type casting when retrieving the value.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 100,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 100,
                        TitleOne = "10. Readonly Variable (readonly)",
                        TitleTwo = "The readonly keyword is used to create a read-only field, and its value can only be assigned at the time of declaration or in the constructor of the containing class. After initialization, the value cannot be changed.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },

                    new MyClassTable
                    {
                        IdClass = 101,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 101,
                        TitleOne = "11. Data Type int",
                        TitleTwo = "Represents a 32-bit signed integer. Range: -2,147,483,648 to 2,147,483,647.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 102,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 102,
                        TitleOne = "12. Data Type  string",
                        TitleTwo = "Represents a sequence of characters (text). Immutable; once created, cannot be modified.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 103,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 103,
                        TitleOne = "13. Data Type bool",
                        TitleTwo = "Represents a Boolean value (true or false)",
                        InfoClass = "Used for logical conditions and decision-making.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 104,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 104,
                        TitleOne = "14. Data Type  char",
                        TitleTwo = "Represents a single Unicode character. Enclosed in single quotes ('').",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 105,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 105,
                        TitleOne = "15. Data Type float",
                        TitleTwo = "Represents a 32-bit single-precision floating-point number.",
                        InfoClass = "Used for decimal numbers with smaller precision.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 106,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 106,
                        TitleOne = "16. Data Type double",
                        TitleTwo = "Represents a 64-bit double-precision floating-point number.",
                        InfoClass = "Used for decimal numbers with higher precision than float.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 107,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 107,
                        TitleOne = "17. Data Type decimal",
                        TitleTwo = "Represents a 128-bit decimal number. Used for financial and monetary calculations where precision is critical.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 108,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 108,
                        TitleOne = "18. Example One Array",
                        TitleTwo = "Declares an array named m of type int with a length of 3.",
                        InfoClass = "Elements are initialized to default values (0 for int).",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 109,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 109,
                        TitleOne = "19. Example Two Array",
                        TitleTwo = "Declares and initializes an array named n of type int with values 1, 2, and 3.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 110,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 110,
                        TitleOne = "20. Example 2D Array",
                        TitleTwo = "Represents a two-dimensional array.",
                        InfoClass = "Used for storing data in a grid, with rows and columns.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 111,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 111,
                        TitleOne = "21. Example Array + Object",
                        TitleTwo = "Arrays can hold elements of any type, including objects.",
                        InfoClass = "Useful for creating arrays of custom objects or mixed data types.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 112,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 112,
                        TitleOne = "22. Array Method Length",
                        TitleTwo = "The Length property of an array returns the total number of elements in the array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 113,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 113,
                        TitleOne = "23. Array Method Sort",
                        TitleTwo = "The Sort method is used to sort the elements of an array in ascending order.",
                        InfoClass = "The default behavior is to sort elements based on their natural order.",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 114,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 114,
                        TitleOne = "24. Array Method  Reverse",
                        TitleTwo = "The Reverse method reverses the order of the elements in an array.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 115,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 115,
                        TitleOne = "25. Array Method IndexOf",
                        TitleTwo = "The IndexOf method returns the index of the first occurrence of a specified value in an array. If the element is not found, it returns -1.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 116,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 116,
                        TitleOne = "26. Array Method Copy",
                        TitleTwo = "The Copy method is used to create a shallow copy of an array. Changes to the elements in the original array do not affect the copied array",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 117,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 117,
                        TitleOne = "27. Dictionary",
                        TitleTwo = "A Dictionary is a collection of key-value pairs. Each key must be unique within the dictionary, and it is associated with a specific value. Provides fast lookup of values based on keys.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 118,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 118,
                        TitleOne = "28. Dictionary Method Add",
                        TitleTwo = "The Add method is used to add a new key-value pair to the dictionary. nIf the key already exists, an exception is thrown (use TryAdd or check for existence before adding to avoid this).",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 119,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 119,
                        TitleOne = "29. Dictionary Method Remove",
                        TitleTwo = "The Remove method is used to remove a key-value pair from the dictionary based on the specified key. Returns true if the removal is successful; otherwise, returns false if the key is not found.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 120,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 120,
                        TitleOne = "30. List",
                        TitleTwo = "A List is a dynamic array that can grow or shrink in size. Elements are ordered and can be accessed by index. Supports various operations for adding, removing, and manipulating elements.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 121,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 121,
                        TitleOne = "31. List Method Add",
                        TitleTwo = "The Add method is used to add an element to the end of the list. Automatically increases the size of the list if needed.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 122,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 122,
                        TitleOne = "32. List Method Remove",
                        TitleTwo = "The Remove method is used to remove the first occurrence of a specific element from the list. Returns true if the element is successfully removed; otherwise, returns false if the element is not found.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 123,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 123,
                        TitleOne = "33. List Method Sort",
                        TitleTwo = "The Sort method is used to sort the elements of the list in ascending order. The default behavior is to sort elements based on their natural order.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 124,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 124,
                        TitleOne = "34. List Method Reverse",
                        TitleTwo = "The Reverse method reverses the order of the elements in the list. Lists are versatile data structures in C# that allow you to work with collections of items in a flexible and dynamic manner. They are commonly used when you need a dynamic array with various built-in operations for managing its content.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 125,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 125,
                        TitleOne = "35. Logical operators",
                        TitleTwo = "in C# are used to manipulate or evaluate Boolean values. They include.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 126,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 126,
                        TitleOne = "36. Comparison operators",
                        TitleTwo = "in C# are used to compare values and produce Boolean results. They include.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 127,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 127,
                        TitleOne = "37. Assignment operators",
                        TitleTwo = "in C# are used to assign values to variables. Here's an overview of common assignment operators.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 128,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 128,
                        TitleOne = "38. Arithmetic operators",
                        TitleTwo = "in C# are symbols used to perform mathematical calculations. Here's a concise overview.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 129,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 129,
                        TitleOne = "39.Flow Structure",
                        TitleTwo = "Flow structure in programming refers to the logical organization and control of the execution flow within a program. It defines the sequence in which statements and instructions are executed. There are three primary types of flow structures.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 130,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 130,
                        TitleOne = "40. IF - ELSE",
                        TitleTwo = "The if-else statement is a control flow statement used for decision-making. It executes a block of code if the specified condition is true; otherwise, it executes an alternative block of code.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 131,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 131,
                        TitleOne = "41. ELSE - IF",
                        TitleTwo = "The else if statement is an extension of the if-else construct. It allows checking multiple conditions sequentially. If the initial if condition is false, it evaluates the next condition provided by the else if.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 132,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 132,
                        TitleOne = "42. Switch",
                        TitleTwo = "The switch statement is used for multi-way branching. It evaluates the value of an expression against multiple possible case values and executes the block of code associated with the first matching case.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 133,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 133,
                        TitleOne = "43. Ternary Operator",
                        TitleTwo = "The ternary operator is a shorthand form of an if-else statement. It evaluates a condition and returns one of two values depending on whether the condition is true or false. It has the form condition ? expression_if_true : expression_if_false;.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 134,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 134,
                        TitleOne = "44. Loop Statements",
                        TitleTwo = "Loop statements in programming are control flow structures that allow a set of instructions to be repeatedly executed as long as a certain condition is true or for a specified number of iterations. These statements enable developers to efficiently perform repetitive tasks without duplicating code.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 135,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 135,
                        TitleOne = "45. For Loop",
                        TitleTwo = "The for loop is a control flow statement used for iterating a specific number of times. It consists of three parts: initialization, condition, and increment/decrement, and executes a block of code as long as the condition is true.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 136,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 136,
                        TitleOne = "46. While Loop",
                        TitleTwo = "The while loop is a control flow statement used for repetitive execution of a block of code. It executes the block as long as the specified condition is true, and the condition is evaluated before each iteration.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 137,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 137,
                        TitleOne = "47. Do-While Loop",
                        TitleTwo = "The do-while loop is similar to the while loop, but it guarantees that the block of code is executed at least once, as the condition is checked after the execution of the block.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 138,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 138,
                        TitleOne = "48. Foreach Loop",
                        TitleTwo = "The foreach loop is used for iterating over elements in arrays or collections. It simplifies the process of iterating through elements without needing an explicit index variable.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 139,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 139,
                        TitleOne = "49. Math.Ab",
                        TitleTwo = "The Math.Abs method returns the absolute value of a numeric expression. It works for various numeric types, such as integers, decimals, floats, and doubles. The absolute value is the distance of a number from zero on the number line, regardless of its sign.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                    new MyClassTable
                    {
                        IdClass = 140,
                        IdCourse = 2,
                        IdType = 1,
                        IdImageClass = 140,
                        TitleOne = "50. Enum",
                        TitleTwo = "An enumeration (enum) in C# is a user-defined type that consists of a set of named integral constants, often referred to as enumerators. Here's a concise definition: An enum is a user-defined data type used to represent a set of named integral constants. nEnumerators within an enum have a distinct integer value, starting from 0 by default.  Enums provide a way to create named, meaningful constants, enhancing code readability.",
                        InfoClass = "",
                        CodeClass = "",
                        LinkRef = "",
                    },
                };

                db.MyClassTables.AddRange(newMyClass);
               await db.SaveChangesAsync();
            }
        }
    }
}
