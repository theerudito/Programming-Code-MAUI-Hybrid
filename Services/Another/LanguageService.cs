using ProgrammingCode.Helpers;

namespace ProgrammingCode.Service.Another
{
	public class LanguageService
	{
		// MENU
		public string Language { get; private set; } = "EN";

		public string HomeLabel { get; private set; } = "Home";
		public string AboutLabel { get; private set; } = "About";
		public string AddCourseLabel { get; private set; } = "Add Course";
		public string AddClassLabel { get; private set; } = "Add Class";
		public string FollowUsLabel { get; private set; } = "Follow US";
		public string LogoutLabel { get; private set; } = "Logout";
		public string WelcomeLabel { get; private set; } = "Welcome";
		public string CompleteLabel { get; private set; } = "Complete";
		public string IncompleteLabel { get; private set; } = "Incomplete";
		public string StartLabel { get; private set; } = "Start";
		public string ContinueLabel { get; private set; } = "Continue";
		public string AddNewCourseLabel { get; private set; } = "ADD NEW COURSE";
		public string FindCourseInput { get; private set; } = "Find Course";
		public string SelectAnCourseLabel { get; private set; } = "SELECT AN COURSE";
		public string SpecialLabel { get; private set; } = "Special Thanks";
		public string ProgrammerLabel { get; private set; } = "Programmer";
		public string TesterLabel { get; private set; } = "Tester";
		public string PolicyLabel { get; private set; } = "Privacy Policy";
		public string DeleteAccountButton { get; private set; } = "DELETE ACCOUNT";
		public string MadeByLabel { get; private set; } = "Made with";
		public string RegisterLabel { get; private set; } = "Register";
		public string LoginLabel { get; private set; } = "Login";
		public string FirstNameInput { get; private set; } = "FirstName";
		public string UserNameInput { get; private set; } = "UserName";
		public string EmailInput { get; private set; } = "Email";
		public string PasswordInput { get; private set; } = "Password";
		public string AlreadyAccountLabel { get; private set; } = "Already have an account?";
		public string NoAccountLabel { get; private set; } = "If you don't have an account?";
		public string PolicyOneLabel { get; private set; } = "By continuing, you automatically agree to our";
		public string PolicyTwoLabel { get; private set; } = "Terms of Service";
		public string PolicyThreeLabel { get; private set; } = "and";
		public string PolicyFourLabel { get; private set; } = "Privacy Policy";
		public string MessageErrorOne { get; private set; } = "The user is already registered";
		public string MessageErrorTwo { get; private set; } = "password or username are incorrect";
		public string MessageAlert { get; private set; } = "Alert!";
		public string InformationLabel { get; private set; } = "Information";

		public event Action? ChangeLanguage;

		public void SetText(string languange)
		{
			if (languange == "EN")
			{
				Language = languange;
				HomeLabel = LanguageApp.LanguageEn[0];
				AboutLabel = LanguageApp.LanguageEn[1];
				AddCourseLabel = LanguageApp.LanguageEn[2];
				AddClassLabel = LanguageApp.LanguageEn[3];
				FollowUsLabel = LanguageApp.LanguageEn[4];
				LogoutLabel = LanguageApp.LanguageEn[5];
				WelcomeLabel = LanguageApp.LanguageEn[6];
				CompleteLabel = LanguageApp.LanguageEn[7];
				IncompleteLabel = LanguageApp.LanguageEn[8];
				StartLabel = LanguageApp.LanguageEn[9];
				ContinueLabel = LanguageApp.LanguageEn[10];
				AddNewCourseLabel = LanguageApp.LanguageEn[11];
				FindCourseInput = LanguageApp.LanguageEn[12];
				SelectAnCourseLabel = LanguageApp.LanguageEn[13];
				SpecialLabel = LanguageApp.LanguageEn[14];
				ProgrammerLabel = LanguageApp.LanguageEn[15];
				TesterLabel = LanguageApp.LanguageEn[16];
				PolicyLabel = LanguageApp.LanguageEn[17];
				DeleteAccountButton = LanguageApp.LanguageEn[18];
				MadeByLabel = LanguageApp.LanguageEn[19];
				RegisterLabel = LanguageApp.LanguageEn[20];
				LoginLabel = LanguageApp.LanguageEn[21];
				FirstNameInput = LanguageApp.LanguageEn[22];
				UserNameInput = LanguageApp.LanguageEn[23];
				EmailInput = LanguageApp.LanguageEn[24];
				PasswordInput = LanguageApp.LanguageEn[25];
				AlreadyAccountLabel = LanguageApp.LanguageEn[26];
				NoAccountLabel = LanguageApp.LanguageEn[27];
				PolicyOneLabel = LanguageApp.LanguageEn[28];
				PolicyTwoLabel = LanguageApp.LanguageEn[29];
				PolicyThreeLabel = LanguageApp.LanguageEn[30];
				PolicyFourLabel = LanguageApp.LanguageEn[31];
				MessageErrorOne = LanguageApp.LanguageEn[32];
				MessageErrorTwo = LanguageApp.LanguageEn[33];
				MessageAlert = LanguageApp.LanguageEn[34];
				InformationLabel = LanguageApp.LanguageEn[35];
			}
			else
			{
				Language = languange;
				HomeLabel = LanguageApp.LanguageEs[0];
				AboutLabel = LanguageApp.LanguageEs[1];
				AddCourseLabel = LanguageApp.LanguageEs[2];
				AddClassLabel = LanguageApp.LanguageEs[3];
				FollowUsLabel = LanguageApp.LanguageEs[4];
				LogoutLabel = LanguageApp.LanguageEs[5];
				WelcomeLabel = LanguageApp.LanguageEs[6];
				CompleteLabel = LanguageApp.LanguageEs[7];
				IncompleteLabel = LanguageApp.LanguageEs[8];
				StartLabel = LanguageApp.LanguageEs[9];
				ContinueLabel = LanguageApp.LanguageEs[10];
				AddNewCourseLabel = LanguageApp.LanguageEs[11];
				FindCourseInput = LanguageApp.LanguageEs[12];
				SelectAnCourseLabel = LanguageApp.LanguageEs[13];
				SpecialLabel = LanguageApp.LanguageEs[14];
				ProgrammerLabel = LanguageApp.LanguageEs[15];
				TesterLabel = LanguageApp.LanguageEs[16];
				PolicyLabel = LanguageApp.LanguageEs[17];
				DeleteAccountButton = LanguageApp.LanguageEs[18];
				MadeByLabel = LanguageApp.LanguageEs[19];
				RegisterLabel = LanguageApp.LanguageEs[20];
				LoginLabel = LanguageApp.LanguageEs[21];
				FirstNameInput = LanguageApp.LanguageEs[22];
				UserNameInput = LanguageApp.LanguageEs[23];
				EmailInput = LanguageApp.LanguageEs[24];
				PasswordInput = LanguageApp.LanguageEs[25];
				AlreadyAccountLabel = LanguageApp.LanguageEs[26];
				NoAccountLabel = LanguageApp.LanguageEs[27];
				PolicyOneLabel = LanguageApp.LanguageEs[28];
				PolicyTwoLabel = LanguageApp.LanguageEs[29];
				PolicyThreeLabel = LanguageApp.LanguageEs[30];
				PolicyFourLabel = LanguageApp.LanguageEs[31];
				MessageErrorOne = LanguageApp.LanguageEs[32];
				MessageErrorTwo = LanguageApp.LanguageEs[33];
				MessageAlert = LanguageApp.LanguageEs[34];
				InformationLabel = LanguageApp.LanguageEs[35];
			}

			ExecuteAction();
		}

		private void ExecuteAction() => ChangeLanguage?.Invoke();
	}
}