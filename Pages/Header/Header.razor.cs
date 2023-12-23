using Microsoft.AspNetCore.Components;
using ProgrammingCode.Helpers;
using ProgrammingCode.Service.Another;

namespace ProgrammingCode.Pages.Header
{
	public partial class Header
	{
		private string _nameUser;

		[Inject]
		private LanguageService LanguageService { get; set; } = null!;

		protected override async Task OnInitializedAsync()
		{
			LanguageService.ChangeLanguage += StateHasChanged;

			_nameUser = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyUser);

			StateHasChanged();
		}
	}
}