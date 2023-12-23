using Microsoft.AspNetCore.Components.Forms;

namespace ProgrammingCode.Helpers
{
	public class ImagenConverterApp
	{
		public static async Task<List<string>> ToBase64(InputFileChangeEventArgs e)
		{
			try
			{
				var file = e.File;

				using var memoryStream = new MemoryStream();
				await file.OpenReadStream().CopyToAsync(memoryStream);

				var fileBytes = memoryStream.ToArray();

				var myList = new List<string>();
				myList.Add($"data:{file.ContentType};base64,{Convert.ToBase64String(fileBytes)}");
				myList.Add(Convert.ToBase64String(fileBytes));

				return myList;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error al procesar la imagen: {ex.Message}");
				return null;
			}
		}

		public static string ToPng(string base64)
		{
			return $"data:image/png;base64,{base64}";
		}
	}
}