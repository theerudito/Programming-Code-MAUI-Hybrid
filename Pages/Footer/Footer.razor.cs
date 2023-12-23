using Microsoft.AspNetCore.Components;
using ProgrammingCode.Service.Another;

namespace ProgrammingCode.Pages.Footer
{
	public partial class Footer
	{
		[Inject]
		private LanguageService LanguageService { get; set; } = null!;

		protected override void OnInitialized()
		{
			LanguageService.ChangeLanguage += StateHasChanged;
		}
	}
}