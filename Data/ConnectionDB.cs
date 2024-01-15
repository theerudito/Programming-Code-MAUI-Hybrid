namespace ProgrammingCode.Data
{
	public class ConnectionDB
	{
		private static string nameDataBase = "n18.db";

		public static string GetConnection()
		{
			string pathDatabase = string.Empty;

			if (DeviceInfo.Platform == DevicePlatform.Android)
			{
				pathDatabase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameDataBase);
			}
			else if (DeviceInfo.Platform == DevicePlatform.iOS)
			{
				pathDatabase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", nameDataBase);
			}
			else if (DeviceInfo.Platform == DevicePlatform.WinUI)
			{
				pathDatabase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nameDataBase);
			}
			return pathDatabase;	
		}
	}
}