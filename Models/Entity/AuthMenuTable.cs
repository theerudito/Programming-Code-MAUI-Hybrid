namespace ProgrammingCode.Models.Entity;

public partial class AuthMenuTable
{
	public int IdAuthMenu { get; set; }

	public int IdUser { get; set; }

	public int IdMenu { get; set; }

	public MenuTable Menu { get; set; } = null!;
    public AuthTable Auth { get; set; } = null!;

}