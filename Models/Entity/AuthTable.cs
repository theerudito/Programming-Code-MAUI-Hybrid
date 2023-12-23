using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingCode.Models.Entity;

public partial class AuthTable
{
	[Key]
	public int IdUser { get; set; }

	public string Name { get; set; } = string.Empty;

	public string UserName { get; set; } = string.Empty;

	public string Email { get; set; } = string.Empty;

	public string Password { get; set; } = string.Empty;

	public int IdRole { get; set; }
	public RoleTable Roles { get; set; } = null!;

    public virtual List<AuthMenuTable> AuthMenuNavigation { get; set; } = new List<AuthMenuTable>();
    public virtual List<ApplicationTable> ApplicationNavigation { get; set; } = new List<ApplicationTable>();
    public virtual List<ClassTable> ClassNavigation { get; set; } = new List<ClassTable>();

}