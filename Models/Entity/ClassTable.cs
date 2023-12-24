namespace ProgrammingCode.Models.Entity;

public partial class ClassTable
{
	public int IdClassOther { get; set; }

	public int IdUser { get; set; }
    public virtual AuthTable Auth { get; set; } = null!;

    public int IdClass { get; set; }
    public virtual MyClassTable MyClass { get; set; } = null!;

    public int IdCourse { get; set; }
    public virtual CourseTable Course { get; set; } = null!;
    public bool CompleteClass { get; set; } = false;

}