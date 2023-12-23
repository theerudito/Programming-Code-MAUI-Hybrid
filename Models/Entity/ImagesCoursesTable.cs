using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Models.Entity;

public partial class ImagesCoursesTable : Images
{
	public int IdImageCourse { get; set; }

	public virtual List<CourseTable> CoursesNavigation { get; set; } = new List<CourseTable>();

}