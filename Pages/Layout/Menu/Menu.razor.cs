using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ProgrammingCode.Helpers;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Service.Another;
using ProgrammingCode.Service.Interface;

namespace ProgrammingCode.Pages.Layout.Menu
{
	public partial class Menu
	{
		private string _versionApp = AppInfo.Version.ToString();
		private string _containerTab = "d-none";
		private string _show = "d-flex";
		private string _hide = "d-none";

		[Inject]
		private IJSRuntime JsRuntime { get; set; } = null!;

		[Inject]
		private LanguageService LanguageService { get; set; } = null!;

		[Inject]
		private ThemeService ThemeService { get; set; } = null!;

		[Inject]
		private NavigationManager Navigation { get; set; } = null!;

		[Inject]
		private IMenu MenuRepository { get; set; } = null!;

		private List<MenuDto> _menuList = new List<MenuDto>();

		protected override async Task OnInitializedAsync()
		{
			MyVariablesApp._themeApp = AppInfo.Current.RequestedTheme.ToString();

			ThemeService.SetTheme(MyVariablesApp._themeApp);

			await JsRuntime.InvokeVoidAsync("bodyColor", ThemeService.BackgroundApp);

			LanguageService.ChangeLanguage += StateHasChanged;

			ThemeService.ChangeTheme += StateHasChanged;

			var iduser = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyIdUser);

			_menuList = await MenuRepository.GetMenu(Convert.ToInt32(iduser));

			StateHasChanged();
		}

		private void OpenBurger() => _containerTab = _show;

		private void CloseBurger() => _containerTab = _hide;

		private async void ChangeTheme()
		{
			MyVariablesApp._themeApp = MyVariablesApp._themeApp == "Dark" ? "Light" : "Dark";

			ThemeService.SetTheme(MyVariablesApp._themeApp);

			await JsRuntime.InvokeVoidAsync("bodyColor", ThemeService.BackgroundApp);
		}

		private void ChangeLanguage()
		{
			MyVariablesApp._languageApp = MyVariablesApp._languageApp == "EN" ? "ES" : "EN";
			LanguageService.SetText(MyVariablesApp._languageApp);

			StateHasChanged();
		}

		private async void LogOut()
		{
			if (MyVariablesApp._languageApp == "EN"
				? await App.Current.MainPage.DisplayAlert("Programming Code", "Are you sure you want to logout?", "YES", "NO")
				: await App.Current.MainPage.DisplayAlert("Programming Code", "Estas Seguro que quieres cerrar seccion", "SI", "NO"))
			{
				LocalStorageDataApp.RemoveItem();
				NavigationManagerApp._inHome = false;
				Navigation.NavigateTo("/auth");
				CloseBurger();
			}
			else
			{
				CloseBurger();
				return;
			}
		}

		private void NavigationApp(string url)
		{
			CloseBurger();
			Navigation.NavigateTo(url);
		}

		private void OpenSocialMedia(string url)
		{
			CloseBurger();
			LauncherManager.OpenBrowser(url);
		}

		public void Dispose()
		{
			LanguageService.ChangeLanguage -= StateHasChanged;
			ThemeService.ChangeTheme -= StateHasChanged;
		}
	}
}