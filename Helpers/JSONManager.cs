using Newtonsoft.Json;

namespace ProgrammingCode.Helpers
{
	public static class JSONManager
	{
        public static List<List<Dictionary<string, string>>> ReadJSON()
        {


            string nameFile = "data.json";
            string wwwrootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot", "json");
            string pathJSON = Path.Combine(wwwrootPath, nameFile);

            if (File.Exists(pathJSON))
            {
                // Obtener la ruta del directorio de datos locales de la aplicación
                string localAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameFile);

                // Copiar el archivo al directorio de datos locales
                File.Copy(pathJSON, localAppDataPath, true);

                // Leer el archivo desde el directorio de datos locales
                var readJSON = File.ReadAllText(localAppDataPath);

                // Deserializar el JSON y retornar el resultado
                return JsonConvert.DeserializeObject<List<List<Dictionary<string, string>>>>(data)!;
            }
            else
            {
                // Si el archivo no existe, retornar una lista vacía
                return new List<List<Dictionary<string, string>>>();
            }
        }
    }
}
