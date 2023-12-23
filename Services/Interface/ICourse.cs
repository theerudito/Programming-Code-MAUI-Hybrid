using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Service.Interface
{
	public interface ICourse
	{
		Task<List<CourseDto>> GetsCourses();

		Task<CourseDto> GetCourseById(int idCourseDto);

		Task<bool> PostCourse(CourseDto courseDto);

		Task<bool> PutCourse(CourseDto courseDto, int idCourseDto);

		Task<bool> DeleteCourse(int idCourseDto);

		Task<bool> SelectedCourse(int idCourseDto);

		Task<List<CourseDto>> SearchingCourse(string searchCourse);
	}
}