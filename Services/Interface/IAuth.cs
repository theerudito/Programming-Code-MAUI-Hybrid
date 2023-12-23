using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Service.Interface
{
	public interface IAuth
	{
		Task<List<AuthDto>> GetAuth();

		Task<AuthDto> GetByIdAuth(int idUserDto);

		Task<bool> RegisterAuth(AuthDto userDto);

		Task<bool> LoginAuth(AuthDto idUserDto);

		Task<bool> PutAuth(AuthDto userDto, int idUserDto);

		Task<bool> DeleteAuth(int idUserDto);
	}
}