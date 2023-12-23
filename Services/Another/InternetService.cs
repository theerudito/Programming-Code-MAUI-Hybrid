using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Networking;

namespace ProgrammingCode.Services.Another
{
	public class InternetService
	{
		public bool isConnected { get; set; } = false;

		public event Action? InternetChange;

		[Inject]
		private NavigationManager navigationManager { get; set; } = null!;

		public void SetInternet()
		{
			//Connectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

			if (Connectivity.NetworkAccess == NetworkAccess.Internet)
			{
				isConnected = true;
				navigationManager.NavigateTo("/home");
			}
			else
			{
				isConnected = false;

				navigationManager.NavigateTo("/404");
			}

			ExecuteAction();
		}

		private void Current_ConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
		{
			if (e.NetworkAccess == NetworkAccess.Internet)
			{
				isConnected = true;
				navigationManager.NavigateTo("/home");
			}
			else
			{
				isConnected = false;
				navigationManager.NavigateTo("/404");
			}

			//Connectivity.NetworkAccess == NetworkAccess.Internet

			//ExecuteAction();
		}

		private void ExecuteAction() => InternetChange?.Invoke();
	}
}