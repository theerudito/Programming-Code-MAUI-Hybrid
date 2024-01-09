

namespace ProgrammingCode
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            string jsonData = ReadDataJson();


        }
        private string ReadDataJson()
        {
            try
            {
                // Obtén la ruta del directorio de archivos internos de la aplicación en Android
                string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "files");

                // Combina la ruta del directorio con el nombre del archivo
                string filePath = Path.Combine(directoryPath, "data.json");

                // Asegúrate de que el directorio exista, si no, créalo
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Lee el contenido del archivo
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                // Maneja las excepciones según tus necesidades
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                return null;
            }
        }

    }
}

