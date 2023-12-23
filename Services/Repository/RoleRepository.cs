using ProgrammingCode.Data;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Models.Entity;

namespace ProgrammingCode.Service.Repository
{
	public class RoleRepository(ApplicationContextDB db)
	{
		public async Task<bool> PostRole(List<RoleDto> myRoleDto)
		{
			try
			{
				var newRoles = new List<RoleTable>
				{
					new RoleTable
					{
						IdRole = myRoleDto[0].IdRole,
						Name = myRoleDto[0].Role,
					},
					new RoleTable
					{
						IdRole = myRoleDto[1].IdRole,
						Name = myRoleDto[1].Role,
					}
				};

				await db.RoleTables.AddRangeAsync(newRoles);
				await db.SaveChangesAsync();
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}
	}
}