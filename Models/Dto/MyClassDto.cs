namespace ProgrammingCode.Models.Dto
{
	public class MyClassDto : Images
	{
		public int IdClass { get; set; }
		public int IdCourse { get; set; }
		public int IdImageClass { get; set; }
		public int IdType { get; set; }
		public string TitleOne { get; set; } = string.Empty;
		public string TitleTwo { get; set; } = string.Empty;
		public string InfoClass { get; set; } = string.Empty;
		public string CodeClass { get; set; } = string.Empty;
		public string LinkRef { get; set; } = string.Empty;
		public bool IsOpen { get; set; }
		public bool Complete { get; set; }
	}
}