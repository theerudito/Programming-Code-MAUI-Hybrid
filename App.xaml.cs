﻿using ProgrammingCode.Helpers;

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
            //InitialValuesTest.AddImagesClass();
            //InitialValues.AddImagesCourse();
            //InitialValues.AddCourse();
            //InitialValues.AddMyClass();

            //         InitialValues.AddRole();
            //         InitialValues.Menu();
            //         InitialValues.AddType();
            //         InitialValues.AddImagesClass();
            //InitialValues.AddImagesCourse();
            //InitialValues.AddCourse();
            //         InitialValues.AddMyClass();

            MainPage = new MainPage();
		}
	}
}