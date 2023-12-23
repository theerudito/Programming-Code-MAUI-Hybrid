namespace ProgrammingCode.Models.Dto
{
	public class ApplicationDto : Images
	{
		public int IdApplication { get; set; }
		public int IdUser { get; set; }
		public int IdCourse { get; set; }
		public int IdImageCourse { get; set; }
		public int IdType { get; set; }
		public int ScoreCourse { get; set; }
		public bool LikeCourse { get; set; }
		public string TitleCourse { get; set; } = string.Empty;
		public string TypeName { get; set; } = string.Empty;
	}
}