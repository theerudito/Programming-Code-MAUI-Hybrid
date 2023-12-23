namespace ProgrammingCode.Models.Dto
{
	public class ResposeAuth
	{
		public int IdUser { get; set; }
		public string NameUser { get; set; } = string.Empty;
		public string Token { get; set; } = string.Empty;
	}
}