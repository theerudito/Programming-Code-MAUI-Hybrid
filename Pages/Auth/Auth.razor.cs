using Microsoft.AspNetCore.Components;
using ProgrammingCode.Service.Another;

namespace ProgrammingCode.Pages.Auth
{
	public partial class Auth
	{
		[Inject]
		private AuthService AuthService { get; set; } = null!;

		protected override void OnInitialized()
		{
			AuthService.ChangeAuth += StateHasChanged;
		}

		public void Dispose()
		{
			AuthService.ChangeAuth -= StateHasChanged;
		}
	}
}