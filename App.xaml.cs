using ProgrammingCode.Helpers;

namespace ProgrammingCode
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			InitialValues.AddRole();
			InitialValues.Menu();
            InitialValues.AddType();

            //InitialValues.AddImagesClass();

            MainPage = new MainPage();
		}
	}
}