using Microsoft.AspNetCore.Components;
using ProgrammingCode.Helpers;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Service.Interface;
using ProgrammingCode.Service.Repository;

namespace ProgrammingCode.Pages.MyClass
{
	public partial class MyClass
	{
		[Parameter]
		public int IdApplication { get; set; } = 0;

		[Parameter]
		public int IdCourse { get; set; } = 0;

		[Parameter]
		public int IdType { get; set; } = 0;

		private string IdUser = "";
		private string _myCourse = "";
		private int IdClass;
		private bool completeClass = false;

		[Inject]
		private MyClassRepository MyClassRepository { get; set; } = null!;

		[Inject]
		private IMyApplication ApplicationRepository { get; set; } = null!;

		[Inject]
		private ICourse CourseRepository { get; set; } = null!;

		[Inject]
		private My_Class_Repository My_Class_Repository { get; set; } = null!;

		private List<MyClassDto> _myClassList = new List<MyClassDto>();

		protected override async Task OnInitializedAsync()
		{
			_myClassList = await MyClassRepository.FindMyClass(IdCourse, IdType);

			var FindCourse = await CourseRepository.GetCourseById(IdCourse);

			_myCourse = FindCourse.Name;

			IdUser = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyIdUser);

			StateHasChanged();
		}

		private async void BtnNextClass(int IdClass)
		{
			completeClass = true;
			var result = await My_Class_Repository.PostData(Convert.ToInt32(IdUser), IdCourse, IdClass);

			if (result == true)
			{
				await ApplicationRepository.ScoreCourse(IdApplication);
				completeClass = true;
			}
		}

		private void OpenMyClass(int IdClass)
		{
			this.IdClass = IdClass;
			completeClass = false;
		}

		private void openBrowser(string url)
		{
			if (string.IsNullOrEmpty(url)) return;
            LauncherManager.OpenBrowser(url);           
		}
	}
}