namespace ProgrammingCode.Models.Entity;

public partial class RoleTable
{
	public int IdRole { get; set; }

	public string Name { get; set; } = null!;

	public virtual List<AuthTable> AuthNavigation { get; set; } = new List<AuthTable>();
}