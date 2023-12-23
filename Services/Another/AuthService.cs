namespace ProgrammingCode.Service.Another
{
	public class AuthService
	{
		public bool _showRegister { get; set; } = true;

		public event Action? ChangeAuth;

		public void ShowRegister(bool showRegister)
		{
			_showRegister = showRegister;
			ExecuteAction();
		}

		private void ExecuteAction() => ChangeAuth?.Invoke();
	}
}