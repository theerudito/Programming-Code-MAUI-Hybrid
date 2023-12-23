namespace ProgrammingCode.Models.Entity;

public partial class CourseTable
{
	public int IdCourse { get; set; }

	public string Name { get; set; } = null!;

	public int IdImageCourse { get; set; }
    public virtual ImagesCoursesTable ImageCourse { get; set; } = null!;

    public int IdType { get; set; }
    public virtual TypeCourseTable TypeCourses { get; set; } = null!;

    public bool SelectedCourse { get; set; } = false;

	public virtual List<ApplicationTable> ApplicationNavigation { get; set; } = new List<ApplicationTable>();
    public virtual List<ClassTable> ClassNavigation { get; set; } = new List<ClassTable>();
    public virtual List<MyClassTable> MyClassTableNavigation { get; set; } = new List<MyClassTable>();
    
}