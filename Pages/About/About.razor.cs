using Microsoft.AspNetCore.Components;
using ProgrammingCode.Helpers;
using ProgrammingCode.Service.Another;
using ProgrammingCode.Services.Repository;

namespace ProgrammingCode.Pages.About
{
	public partial class About
	{
		private string _idUser;

		[Inject]
		private DataUserRepository DataUserRepository { get; set; } = null!;
       
        [Inject]
		private LanguageService LanguageService { get; set; } = null!;

		[Inject]
		private ThemeService ThemeService { get; set; } = null!;

		[Inject]
		private NavigationManager Navigation { get; set; } = null!;

		protected override async Task OnInitializedAsync()
		{
			_idUser = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyIdUser);
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
                await DataUserRepository.AuthUser(Convert.ToInt32(_idUser));
				await DataUserRepository.ApplicationUser(Convert.ToInt32(_idUser));
                await DataUserRepository.MenuAuthUser(Convert.ToInt32(_idUser));
                await DataUserRepository.ClassUser(Convert.ToInt32(_idUser));
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