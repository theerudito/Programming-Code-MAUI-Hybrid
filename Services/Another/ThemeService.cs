using ProgrammingCode.Helpers;

namespace ProgrammingCode.Service.Another
{
	public class ThemeService
	{
		public string BackgroundApp { get; private set; }
		public string _themeApp { get; private set; }

		public event Action? ChangeTheme;

		public void SetTheme(string theme)
		{
			if (theme == "Dark")
			{
				BackgroundApp = ThemeManager.ThemeDark[0];
				_themeApp = theme;
			}
			else
			{
				BackgroundApp = ThemeManager.ThemeLight[0];
				_themeApp = theme;
			}

			ExecuteAction();
		}

		private void ExecuteAction() => ChangeTheme?.Invoke();
	}
}