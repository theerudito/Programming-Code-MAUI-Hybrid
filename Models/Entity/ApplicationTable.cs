namespace ProgrammingCode.Models.Entity;

public partial class ApplicationTable
{
	public int IdApplication { get; set; }

	public int ScoreCourse { get; set; } = 0;

	public int IdCourse { get; set; }
	public CourseTable Courses { get; set; } = null!;
	
	public int IdUser { get; set; }
	public AuthTable Auth { get; set; } = null!;

	public int IdType { get; set; } 
	public TypeCourseTable TypeCourses { get; set; } = null!;

	public bool LikeCourse { get; set; } = false;

}