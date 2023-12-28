namespace ProgrammingCode.Models.Entity;

public partial class MyClassTable
{
	public int IdClass { get; set; }

	public string TitleOne { get; set; } = null!;

	public string TitleTwo { get; set; } = null!;

	public string InfoClass { get; set; } = null!;

	public string? CodeClass { get; set; }

	public string? LinkRef { get; set; }

	public int IdCourse { get; set; }
    public virtual CourseTable Course { get; set; } = null!;


    public int IdImageClass { get; set; }
    public virtual ImagesClassTable ImageClass { get; set; } = null!;


    public int IdType { get; set; }
    public virtual TypeCourseTable TypeCourses { get; set; } = null!;


	public virtual List<ClassTable> ClassNavigation { get; set; } = new List<ClassTable>();
}