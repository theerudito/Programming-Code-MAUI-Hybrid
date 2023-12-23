using ProgrammingCode.Models.Dto;

namespace ProgrammingCode.Service.Interface
{
	public interface IMyApplication
	{
		Task<List<ApplicationDto>> GetDataApplication(int idUserDto);

		Task<bool> PostDataApplication(ApplicationDto myApplicationDto);

		Task<bool> PutDataApplication(ApplicationDto myApplicationDto, int idApplicationDto);

		Task<bool> DeleteDataApplication(int idUserDto);

		Task<bool> LikeCourse(int idApplicationDto);

		Task<bool> ScoreCourse(int idApplicationDto);

		Task<List<ApplicationDto>> SearchingMyApplication(string seachDataDto, int idUserDto);
	}
}