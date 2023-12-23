namespace ProgrammingCode.Helpers
{
	public class LauncherManager
	{
		public static void OpenBrowser(string url)
		{
			Launcher.OpenAsync(new Uri(url));
		}
	}
}