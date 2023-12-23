namespace ProgrammingCode.Models.Entity;

public partial class TypeCourseTable
{
	public int IdType { get; set; }

	public string Name { get; set; } = null!;

    public virtual List<ApplicationTable> ApplicationNavigation { get; set; } = new List<ApplicationTable>();
    public virtual List<CourseTable> CourseNavigation { get; set; } = new List<CourseTable>();
    public virtual List<MyClassTable> MyClassTableNavigation { get; set; } = new List<MyClassTable>();
}