using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using ProgrammingCode.Helpers;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Service.Interface;
using ProgrammingCode.Service.Repository;

namespace ProgrammingCode.Pages.AddCourse
{
	public partial class AddCourse
	{
		private int _idCourse = 0;
        private string _idUser;

        [Inject]
		private ICourse CourseRepository { get; set; } = null!;

		[Inject]
		private ImagesCoursesRepository ImageCoursesRepository { get; set; } = null!;

		[Inject]
		private CourseTypesRepository CourseTypesRepository { get; set; } = null!;

		private ImagesCourseDto _imagesCourse = new ImagesCourseDto();
		private List<ImagesCourseDto> _listImages = new List<ImagesCourseDto>();

		private CourseDto _course = new CourseDto();
		private List<CourseDto> _listCourse = new List<CourseDto>();

		private List<TypeCourseDto> _courseTypeList = new List<TypeCourseDto>();

		protected override async Task OnInitializedAsync()
		{
			MyVariablesApp._displayInput = "d-none";

			_listImages = await ImageCoursesRepository.GetImagesCourses();

            _idUser = await LocalStorageDataApp.GetItem(LocalStorageDataApp.KeyIdUser);

			_listCourse = await CourseRepository.GetsCourses();

			_courseTypeList = await CourseTypesRepository.GetTypes();
		}

		private async void ReloadData()
		{
			await OnInitializedAsync();
			StateHasChanged();
		}

		private async Task SearchCourse(ChangeEventArgs e)
		{
			MyVariablesApp._searchData = e.Value.ToString();

			var course = await CourseRepository.SearchingCourse(MyVariablesApp._searchData!);

			if (course == null)
			{
				_listCourse = await CourseRepository.GetsCourses();
			}
			else
			{
				_listCourse = course;
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
				ReloadData();
			}
		}

		private async Task SaveNewCourse()
		{
			var addCourse = new CourseDto
			{
				Name = _course.Name,
				IdImageCourse = _course.IdImageCourse,
				IdType = _course.IdType,
				SelectedCourse = false
			};

			if (_idCourse == 0)
			{
				await CourseRepository.PostCourse(addCourse);
			}
			else
			{
				await CourseRepository.PutCourse(addCourse, _idCourse);
			}
			ReloadData();
			await CloseModal(MyVariablesApp.ModalAddCourseRef);
		}

		private async Task UpLoadImage()
		{
			var newImage = new ImagesCourseDto
			{
				NameImage = _imagesCourse.NameImage,
				ImageUrl = _imagesCourse.ImageUrl == null ? "" : _imagesCourse.ImageUrl,
				ImageBase64 = MyVariablesApp.ImageBase64 == null ? "" : MyVariablesApp.ImageBase64,
				RefImage = Guid.NewGuid().ToString().ToUpper()
            };
			ReloadData();

			await CloseModal(MyVariablesApp.ModalAddImageRef);

			await ImageCoursesRepository.PostImageCourse(newImage);
		}

		private async Task GetCourse(CourseDto myCourse)
		{
			_idCourse = myCourse.IdCourse;
			_course.IdCourse = myCourse.IdCourse;
			_course.Name = myCourse.Name;
			_course.IdImageCourse = myCourse.IdImageCourse;
			_course.IdType = myCourse.IdType;

			await OpenModal(MyVariablesApp.ModalAddCourseRef);
		}

		private async Task LoadImage(InputFileChangeEventArgs e)
		{
			var contentFile = e.File.ContentType;

			if (contentFile == "image/png" || contentFile == "image/jpeg" || contentFile == "image/svg+xml")
			{
				var dataImage = await ImagenConverterApp.ToBase64(e);

				MyVariablesApp.ImageDefault = dataImage[0];
				MyVariablesApp.ImageBase64 = dataImage[1];
			}
			else
			{
				return;
			}
		}

		private Task OpenModal(Modal myModal)
		{
			return MyVariablesApp.ModalAddCourseRef == myModal
				? MyVariablesApp.ModalAddCourseRef.Show()
				: MyVariablesApp.ModalAddImageRef.Show();
		}

		private Task CloseModal(Modal myModal)
		{
			if (MyVariablesApp.ModalAddCourseRef == myModal)
			{
				_course.Name = "";
				_course.IdImageCourse = 0;
				_course.IdType = 0;
				_idCourse = 0;
				return MyVariablesApp.ModalAddCourseRef.Hide();
			}
			else
			{
				MyVariablesApp.ImageDefault = "/assets/code.svg";
				_imagesCourse.NameImage = "";
				_imagesCourse.ImageBase64 = "";
				_imagesCourse.ImageUrl = "";
				MyVariablesApp.ImageBase64 = null;
				return MyVariablesApp.ModalAddImageRef.Hide();
			}
		}
	}
}