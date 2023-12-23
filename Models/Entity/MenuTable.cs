namespace ProgrammingCode.Models.Entity;
public partial class MenuTable
{
	public int IdMenu { get; set; }

	public string NameMenu { get; set; } = null!;

	public string NameLink { get; set; } = null!;

	public virtual List<AuthMenuTable> AuthMenuNavigation { get; set; } = new List<AuthMenuTable>();
}