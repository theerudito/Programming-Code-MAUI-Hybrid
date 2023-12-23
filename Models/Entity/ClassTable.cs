namespace ProgrammingCode.Models.Entity;

public partial class ClassTable
{
	public int IdClassOther { get; set; }

	public int IdUser { get; set; }

	public int IdClass { get; set; }

	public int IdCourse { get; set; }
	public bool CompleteClass { get; set; } = false;

	public virtual AuthTable Auth { get; set; } = null!;
	public virtual MyClassTable MyClass { get; set; } = null!;
    public virtual CourseTable Course { get; set; } = null!;
}