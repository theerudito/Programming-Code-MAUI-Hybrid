using Microsoft.AspNetCore.Components;
using ProgrammingCode.Helpers;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Service.Another;
using ProgrammingCode.Service.Interface;

namespace ProgrammingCode.Pages.CourseList
{
	public partial class Courses
	{
		string _idUserDto;

        [Inject]
		private LanguageService LanguageService { get; set; } = null!;

		[Inject]
		private NavigationManager Navigation { get; set; } = null!;

		[Inject]
		private IMyApplication ApplicationRepository { get; set; } = null!;

		[Inject]
		private ICourse CourseRepository { get; set; } = null!;

		private List<CourseDto> _listCourse = new List<CourseDto>();

		private List<ApplicationDto> _myApplication = new List<ApplicationDto>();

		protected override async Task OnInitializedAsync()
		{
			LanguageService.ChangeLanguage += StateHasChanged;

			MyVariablesApp._displayInput = "d-none";

			_listCourse = await CourseRepository.GetsCourses();

            _idUserDto = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyIdUser);

			_myApplication = await ApplicationRepository.GetDataApplication(Convert.ToInt32(_idUserDto));
		}

		public async void ReloadData()
		{
			await OnInitializedAsync();
			this.StateHasChanged();
		}

		public async Task SearchMyCourse(ChangeEventArgs e)
		{
			MyVariablesApp._searchData = e.Value.ToString();

			var infor = await ApplicationRepository.SearchingMyApplication(MyVariablesApp._searchData!, Convert.ToInt32(_idUserDto));

			if (infor == null)
			{
				_myApplication = await ApplicationRepository.GetDataApplication(Convert.ToInt32(_idUserDto));
			}
			else
			{
				_myApplication = infor;
			}
		}

		private void ShowInput()
		{
			if (MyVariablesApp._isSeaching == false)
			{
				MyVariablesApp._displayInput = "d-flex";
				MyVariablesApp._isSeaching = true;
			}
			else
			{
				MyVariablesApp._displayInput = "d-none";
				MyVariablesApp._isSeaching = false;
			}
		}

		private async void LikeCourse(int idApplication)
		{
			await ApplicationRepository.LikeCourse(idApplication);
			ReloadData();
		}

		private void NavigateMyClass(ApplicationDto Application)
		{
			Navigation.NavigateTo($"/myclass/{Application.IdApplication}/{Application.IdCourse}/{Application.IdType}");
		}

		private async void SelectCourse(CourseDto myCourse)
		{
			var myNewCourse = new ApplicationDto
			{
				IdUser = Convert.ToInt32(_idUserDto),
				IdCourse = myCourse.IdCourse,
				IdType = myCourse.IdType,
				TitleCourse = myCourse.Name,
				ScoreCourse = 0,
				LikeCourse = false,
				ImageUrl = myCourse.ImageUrl,
				ImageBase64 = myCourse.ImageBase64,
				RefImage = myCourse.RefImage,
			};

			var courseApplication = await ApplicationRepository.PostDataApplication(myNewCourse);

			if (courseApplication == true)
			{
				await CourseRepository.SelectedCourse(myCourse.IdCourse);
				await CloseModal();
			}
			else
			{
				await CloseModal();
			}
			ReloadData();
		}

		private Task OpenModal() => MyVariablesApp.ModalCourseList.Show();

		private Task CloseModal() => MyVariablesApp.ModalCourseList.Hide();

		public void Dispose()
		{
			LanguageService.ChangeLanguage -= StateHasChanged; ;
		}
	}
}