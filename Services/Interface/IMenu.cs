using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Service.Interface
{
	public interface IMenu
	{
		Task<List<MenuDto>> GetMenu(int idUserDto);

		Task<bool> PostMenus(string userAdmin, string userNameDto);
		Task<bool> DeleteMenuUser(int idUserDto);

    }
}