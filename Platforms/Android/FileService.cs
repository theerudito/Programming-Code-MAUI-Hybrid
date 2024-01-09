using ProgrammingCode.Platforms.Android;
using ProgrammingCode.Services.Another;

[assembly: Dependency(typeof(FileService))]
namespace ProgrammingCode.Platforms.Android
{
    public  class FileService : IFileService
    {
        private string destinationFolder = FileSystem.Current.AppDataDirectory;

        public string GetDestinationFolder()
        {
            return destinationFolder;
        }
    }
}
