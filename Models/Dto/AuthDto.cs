namespace ProgrammingCode.Models.Dto
{
	public class AuthDto 
	{
		public int IdUser { get; set; }
		public string Name { get; set; } = string.Empty;
		public string UserName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public string Token { get; set; } = string.Empty;
	}
}