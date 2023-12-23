using Microsoft.AspNetCore.Components;
using ProgrammingCode.Services.Another;

namespace ProgrammingCode.Pages.NoInternet
{
	public partial class PageNoInternet
	{
		[Inject]
		private InternetService InternetService { get; set; } = null!;

		protected override void OnInitialized()
		{
			InternetService.InternetChange += StateHasChanged;
		}

		public void Dispose()
		{
			InternetService.InternetChange -= StateHasChanged;
		}
	}
}