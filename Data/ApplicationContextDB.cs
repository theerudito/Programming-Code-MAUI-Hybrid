using Microsoft.EntityFrameworkCore;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Data
{
    public class ApplicationContextDB : DbContext
    {
        public virtual DbSet<ApplicationTable> ApplicationTables { get; set; }

        public virtual DbSet<AuthMenuTable> AuthMenuTables { get; set; }

        public virtual DbSet<AuthTable> AuthTables { get; set; }

        public virtual DbSet<ClassTable> ClassTables { get; set; }

        public virtual DbSet<CourseTable> CourseTables { get; set; }

        public virtual DbSet<ImagesClassTable> ImagesClassTables { get; set; }

        public virtual DbSet<ImagesCoursesTable> ImagesCoursesTables { get; set; }

        public virtual DbSet<MenuTable> MenuTables { get; set; }

        public virtual DbSet<MyClassTable> MyClassTables { get; set; }

        public virtual DbSet<RoleTable> RoleTables { get; set; }

        public virtual DbSet<TypeCourseTable> TypeCourseTables { get; set; }

        public ApplicationContextDB()
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

        public ApplicationContextDB(DbContextOptions<ApplicationContextDB> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = $"Filename={ConnectionDB.GetConnection()}";

            Console.WriteLine("Connection String: " + connection);
            optionsBuilder.UseSqlite(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleTable>(entity =>
            {
                entity.ToTable("RoleTable");
                entity.HasKey(r => r.IdRole).HasName("PK_RoleTable");
                entity.Property(r => r.Name).IsRequired();
                entity.HasData(InitialValues._listRole);

                entity.HasMany(r => r.AuthNavigation)
                      .WithOne(a => a.Roles)
                      .HasForeignKey(a => a.IdRole)
                      .HasConstraintName("role_fk");
            });

            modelBuilder.Entity<AuthTable>(entity =>
            {
                entity.ToTable("AuthTable");
                entity.HasKey(a => a.IdUser).HasName("PK_AuthTable");
                entity.Property(a => a.Name).IsRequired();
                entity.Property(a => a.UserName).IsRequired();
                entity.Property(a => a.Email).IsRequired();
                entity.Property(a => a.Password).IsRequired();
                entity.Property(a => a.IdRole).IsRequired();
                entity.HasData(InitialValues._listAuth);

                entity.HasMany(a => a.AuthMenuNavigation)
                 .WithOne(a => a.Auth)
                 .HasForeignKey(a => a.IdUser)
                 .HasConstraintName("auth_fk");

                entity.HasMany(a => a.ClassNavigation)
                      .WithOne(a => a.Auth)
                      .HasForeignKey(a => a.IdUser)
                      .HasConstraintName("auth_fk");

                entity.HasMany(a => a.ApplicationNavigation)
                      .WithOne(a => a.Auth)
                      .HasForeignKey(a => a.IdUser)
                      .HasConstraintName("auth_fk");
            });

            modelBuilder.Entity<AuthMenuTable>(entity =>
            {
                entity.ToTable("AuthMenuTable");
                entity.HasKey(am => am.IdAuthMenu).HasName("PK_AuthMenuTable");
                entity.Property(am => am.IdUser).IsRequired();
                entity.Property(am => am.IdMenu).IsRequired();
                entity.HasData(InitialValues._listAuthMenu);
            });

            modelBuilder.Entity<MenuTable>(entity =>
            {
                entity.ToTable("MenuTable");
                entity.HasKey(m => m.IdMenu).HasName("PK_MenuTable");
                entity.Property(m => m.NameMenu).IsRequired();
                entity.Property(m => m.NameLink).IsRequired();
                entity.HasData(InitialValues._listMenu);

                entity.HasMany(m => m.AuthMenuNavigation)
                      .WithOne(m => m.Menu)
                      .HasForeignKey(m => m.IdMenu)
                      .HasConstraintName("menu_fk");
            });

            modelBuilder.Entity<ClassTable>(entity =>
            {
                entity.ToTable("ClassTable");
                entity.HasKey(c => c.IdClassOther).HasName("PK_ClassTable");
                entity.Property(c => c.IdClass).IsRequired();
                entity.Property(c => c.IdCourse).IsRequired();
                entity.Property(c => c.IdUser).IsRequired();
            });

            modelBuilder.Entity<ImagesClassTable>(entity =>
            {
                entity.ToTable("ImagesClassTable");
                entity.HasKey(ic => ic.IdImageClass).HasName("PK_ImagesClassTable");
                entity.Property(ic => ic.NameImage).IsRequired();
                entity.Property(ic => ic.ImageUrl);
                entity.Property(ic => ic.RefImage);
                entity.Property(ic => ic.ImageBase64);
                entity.HasData(InitialValues._listImagesClass);

                entity.HasMany(ic => ic.MyClassTableNavigation)
                      .WithOne(ic => ic.ImageClass)
                      .HasForeignKey(ic => ic.IdImageClass)
                      .HasConstraintName("imagemyclass_fk");
            });

            modelBuilder.Entity<MyClassTable>(entity =>
            {
                entity.ToTable("MyClassTable");
                entity.HasKey(mc => mc.IdClass).HasName("PK_MyClassTable");
                entity.Property(mc => mc.TitleOne).IsRequired();
                entity.Property(mc => mc.TitleTwo).IsRequired();
                entity.Property(mc => mc.InfoClass);
                entity.Property(mc => mc.CodeClass);
                entity.Property(mc => mc.LinkRef);
                entity.Property(mc => mc.IdType).IsRequired();
                entity.Property(mc => mc.IdCourse).IsRequired();
                entity.Property(mc => mc.IdImageClass).IsRequired();
                entity.HasData(InitialValues._listMyClass);

                entity.HasMany(mc => mc.ClassNavigation)
                      .WithOne(mc => mc.MyClass)
                      .HasForeignKey(mc => mc.IdClass)
                      .HasConstraintName("class_fk");
            });

            modelBuilder.Entity<ImagesCoursesTable>(entity =>
            {
                entity.ToTable("ImagesCoursesTable");
                entity.HasKey(ic => ic.IdImageCourse).HasName("PK_ImagesCoursesTable");
                entity.Property(ic => ic.NameImage).IsRequired();
                entity.Property(ic => ic.ImageUrl);
                entity.Property(ic => ic.RefImage);
                entity.Property(ic => ic.ImageBase64);
                entity.HasData(InitialValues._listImagesCourse);

                entity.HasMany(ic => ic.CoursesNavigation)
                      .WithOne(ic => ic.ImageCourse)
                      .HasForeignKey(a => a.IdImageCourse)
                      .HasConstraintName("imagecourse_fk");
            });

            modelBuilder.Entity<CourseTable>(entity =>
            {
                entity.ToTable("CourseTable");
                entity.HasKey(c => c.IdCourse).HasName("PK_CourseTable");
                entity.Property(c => c.Name).IsRequired();
                entity.Property(c => c.IdType).IsRequired();
                entity.Property(c => c.IdImageCourse).IsRequired();
                entity.HasData(InitialValues._listCourses);

                entity.HasMany(c => c.ApplicationNavigation)
                      .WithOne(c => c.Courses)
                      .HasForeignKey(c => c.IdCourse)
                      .HasConstraintName("course_fk");

                entity.HasMany(c => c.MyClassTableNavigation)
                      .WithOne(c => c.Course)
                      .HasForeignKey(c => c.IdCourse)
                      .HasConstraintName("course_fk");

                entity.HasMany(c => c.ClassNavigation)
                      .WithOne(c => c.Course)
                      .HasForeignKey(c => c.IdCourse)
                      .HasConstraintName("course_fk");
            });

            modelBuilder.Entity<TypeCourseTable>(entity =>
            {
                entity.ToTable("TypeCourseTable");
                entity.HasKey(t => t.IdType).HasName("PK_TypeCourseTable");
                entity.Property(t => t.Name).IsRequired();
                entity.HasData(InitialValues._listTypeCourse);

                entity.HasMany(t => t.CourseNavigation)
                      .WithOne(t => t.TypeCourses)
                      .HasForeignKey(t => t.IdType)
                      .HasConstraintName("type_fk");

                entity.HasMany(t => t.MyClassTableNavigation)
                      .WithOne(t => t.TypeCourses)
                      .HasForeignKey(t => t.IdType)
                      .HasConstraintName("type_fk");

                entity.HasMany(u => u.ApplicationNavigation)
                     .WithOne(a => a.TypeCourses)
                     .HasForeignKey(a => a.IdType)
                     .HasConstraintName("type_fk");
            });

            modelBuilder.Entity<ApplicationTable>(entity =>
            {
                entity.ToTable("ApplicationTable");
                entity.HasKey(a => a.IdApplication).HasName("PK_ApplicationTable");
                entity.Property(a => a.ScoreCourse).IsRequired();
                entity.Property(a => a.IdCourse).IsRequired();
                entity.Property(a => a.IdType).IsRequired();
                entity.Property(a => a.IdUser).IsRequired();
                entity.Property(a => a.LikeCourse).HasDefaultValue(false);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}