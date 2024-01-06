namespace ProgrammingCode.Models.Dto
{
	public class CourseDto : Images
	{
        public int IdCourse { get; set; }
        public int IdImageCourse { get; set; }
        public int IdType { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
        public bool SelectedCourse { get; set; }
    }
}