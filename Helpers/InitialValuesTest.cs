﻿using ProgrammingCode.Data;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Helpers
{
    public class InitialValuesTest
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

        public static void Menu()
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
                db.SaveChanges();
            }
        }

        public static void AddImagesClass()
        {
            var db = new ApplicationContextDB();

            
        }
    }
}