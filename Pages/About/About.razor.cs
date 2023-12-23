using Microsoft.AspNetCore.Components;
using ProgrammingCode.Helpers;
using ProgrammingCode.Service.Another;
using ProgrammingCode.Service.Interface;
using ProgrammingCode.Service.Repository;

namespace ProgrammingCode.Pages.About
{
	public partial class About
	{
		private string IdUser;

		[Inject]
		private IMyApplication IMyApplication { get; set; } = null!;

		[Inject]
		private IAuth IAuth { get; set; } = null!;

        [Inject]
        private My_Class_Repository MyClass { get; set; } = null!;

        [Inject]
        private IMenu IMenu { get; set; } = null!;
       
        [Inject]
		private LanguageService LanguageService { get; set; } = null!;

		[Inject]
		private ThemeService ThemeService { get; set; } = null!;

		[Inject]
		private NavigationManager Navigation { get; set; } = null!;

		protected override async Task OnInitializedAsync()
		{
			IdUser = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyIdUser);
			LanguageService.ChangeLanguage += StateHasChanged;
			ThemeService.ChangeTheme += StateHasChanged;
		}

		public async void DeleteAccount()
		{
			if (MyVariablesApp._languageApp == "EN"
				 ? await App.Current.MainPage.DisplayAlert("Programming Code", "Are you sure you want to delete your account, this is unacceptable?", "YES", "NO")
				 : await App.Current.MainPage.DisplayAlert("Programming Code", "Estas Seguro que quieres borrar tu cuenta esto es irrebesible?", "SI", "NO"))
			{
				LocalStorageDataApp.RemoveItem();
                await IAuth.DeleteAuth(Convert.ToInt32(IdUser));
				await IMenu.DeleteMenuUser(Convert.ToInt32(IdUser));
                await IMyApplication.DeleteDataApplication(Convert.ToInt32(IdUser));
                await MyClass.DeleteDataUser(Convert.ToInt32(IdUser));
                NavigationManagerApp._inHome = false;
				Navigation.NavigateTo("/auth");
			}
			else
			{
				return;
			}
		}

		public void Dispose()
		{
			LanguageService.ChangeLanguage -= StateHasChanged;
			ThemeService.ChangeTheme += StateHasChanged;
		}
	}
}