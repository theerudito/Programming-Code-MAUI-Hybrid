using Microsoft.AspNetCore.Components;
using ProgrammingCode.Helpers;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Service.Another;
using ProgrammingCode.Service.Interface;

namespace ProgrammingCode.Pages.Auth
{
	public partial class Register
	{
		private bool _mySpinner;
		private bool _myAlert;
		private string _messages;

		[Inject]
		private LanguageService LanguageService { get; set; } = null!;

		[Inject]
		private AuthService AuthService { get; set; } = null!;

		[Inject]
		private NavigationManager Navigation { get; set; } = null!;

		[Inject]
		private IAuth AuthRepository { get; set; } = null!;

		private AuthDto _authData = new AuthDto();

		protected override void OnInitialized()
		{
			_mySpinner = false;

			LanguageService.ChangeLanguage += StateHasChanged;

			AuthService.ChangeAuth += StateHasChanged;

			StateHasChanged();
		}

		private async Task BtnRegister()
		{
			_messages = ValidationesManagerApp.MaxAndMinLengthRegister(_authData, LanguageService.Language);

			if (ValidationesManagerApp.MaxAndMinLengthRegister(_authData, LanguageService.Language) == "OK")
			{
				LoadSpinner(true);

				var dataUser = await AuthRepository.RegisterAuth(_authData);

				if (dataUser == true)
				{
					await Task.Delay(1000);

					LoadSpinner(false);

					NavigationManagerApp._inHome = true;

					Navigation.NavigateTo("/");
				}
				else
				{
					_myAlert = true;

					await Task.Delay(2000);

					LoadSpinner(false);

					_myAlert = false;
				}
			}
			else
			{
				await AlertsManagerApp.ShowAlert("Programming Code", _messages, "OK");
			}
		}

		private void BtnShowLogin()
		{
			AuthService.ShowRegister(false);
		}

		private void LoadSpinner(bool isTrue)
		{
			_mySpinner = isTrue;
		}

		public void Dispose()
		{
			LanguageService.ChangeLanguage -= StateHasChanged; ;
		}
	}
}