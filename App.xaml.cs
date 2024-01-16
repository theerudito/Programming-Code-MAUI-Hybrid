using ProgrammingCode.Helpers;

namespace ProgrammingCode
{
	public partial class App : Application
	{
		public App()
		{

            InitializeComponent();

            InitialValuesTest.AddRole();
            InitialValuesTest.Menu();
            InitialValuesTest.AddUser();
            InitialValuesTest.AddType();
            InitialValuesTest.AddImagesCourse();
            InitialValuesTest.AddImagesClass();
            InitialValuesTest.AddCourse();
            InitialValuesTest.AddMyClass();


            //InitialValues.AddRole();
            //InitialValues.Menu();
            //InitialValues.AddType();
            //InitialValues.AddImagesCourse();
            //InitialValues.AddImagesClass();
            //InitialValues.AddCourse();
            //InitialValues.AddMyClass();

            MainPage = new MainPage();
		}
	}
}