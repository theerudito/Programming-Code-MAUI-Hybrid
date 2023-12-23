using Microsoft.AspNetCore.Components;
using ProgrammingCode.Helpers;
using ProgrammingCode.Services.Another;

namespace ProgrammingCode.Pages.Layout
{
	public partial class MainLayout
	{
		[Inject]
		private NavigationManager Navigation { get; set; } = null!;

		[Inject]
		private InternetService InternetService { get; set; } = null!;

		protected override async Task OnInitializedAsync()
		{
			InternetService.InternetChange += StateHasChanged;

			var toke = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyToken);

			if (toke != null)
			{
				Navigation.NavigateTo("/");
				NavigationManagerApp._inHome = true;
			}
			else
			{
				Navigation.NavigateTo("/auth");
				NavigationManagerApp._inHome = false;
			}
			this.StateHasChanged();

			//if (InternetService.isConnected == false)
			//{
			//}
			//else
			//{
			//	Navigation.NavigateTo("/404");

			//	this.StateHasChanged();
			//}
		}

		public void Dispose()
		{
			InternetService.InternetChange -= StateHasChanged;
		}
	}
}