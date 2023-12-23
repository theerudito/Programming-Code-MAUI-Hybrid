using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using ProgrammingCode.Helpers;
using ProgrammingCode.Models.Dto;
using ProgrammingCode.Service.Interface;
using ProgrammingCode.Service.Repository;

namespace ProgrammingCode.Pages.AddClass
{
	public partial class AddClass
	{
		private int _idClass = 0;
        private int _idCourse = 0;

        [Inject]
		private ICourse CourseRepository { get; set; } = null!;

		[Inject]
		private CourseTypesRepository CourseTypesRepository { get; set; } = null!;

		[Inject]
		private ImagesClassRepository ImageClassRepository { get; set; } = null!;

		[Inject]
		private MyClassRepository MyClassRepository { get; set; } = null!;

		private ImagesClassDto _imagesClass = new ImagesClassDto();
		private List<ImagesClassDto> _listImagesClass = new List<ImagesClassDto>();

		private CourseDto _courses = new CourseDto();
		private List<CourseDto> _listCourse = new List<CourseDto>();

		private List<TypeCourseDto> _courseTypeList = new List<TypeCourseDto>();

		private MyClassDto _myClass = new MyClassDto();
		private List<MyClassDto> _myClassList = new List<MyClassDto>();

		protected override async Task OnInitializedAsync()
		{
			MyVariablesApp._displayInput = "d-none";

			_myClassList = await MyClassRepository.GetMyClass();

            _listImagesClass = await ImageClassRepository.GetImagesClass(_courses.Name);

			_listCourse = await CourseRepository.GetsCourses();

			_courseTypeList = await CourseTypesRepository.GetTypes();
		}

		private async void ReloadData()
		{
			await OnInitializedAsync();
			StateHasChanged();
		}

		private async Task SearchClass(ChangeEventArgs e)
		{
			MyVariablesApp._searchData = e.Value.ToString();

			var myclass = await MyClassRepository.SeachingClass(MyVariablesApp._searchData!);

			if (myclass == null)
			{
				_myClassList = await MyClassRepository.GetMyClass();
			}
			else
			{
				_myClassList = myclass;
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

		private void GetIdCourse(int idCourse)
		{
			var selectedCourse = _listCourse.FindAll(x => x.IdCourse == idCourse).FirstOrDefault();
			if (selectedCourse != null)
			{
				_idCourse = selectedCourse.IdCourse;
				_courses.IdCourse = selectedCourse.IdCourse;
				_courses.Name = selectedCourse.Name;
				//_listImagesClass = ImageClassRepository.GetImagesClass(_courses.Name).Result;
			}
			else
			{
				return;
			}
		}

		private async Task SaveNewClass()
		{
			var newClass = new MyClassDto
			{
				TitleOne = _myClass.TitleOne,
				TitleTwo = _myClass.TitleTwo,
				InfoClass = _myClass.InfoClass,
				CodeClass = _myClass.CodeClass,
				LinkRef = _myClass.LinkRef,
				IdImageClass = _myClass.IdImageClass,
				IdCourse = _myClass.IdCourse,
				IdType = _myClass.IdType,
				IdClass = _myClass.IdClass
			};
			if (_idClass == 0)
			{
				await MyClassRepository.PostMyClass(newClass);
			}
			else
			{
				await MyClassRepository.PutMyClass(newClass, _idClass);
			}
			ReloadData();
			await CloseModal(MyVariablesApp.ModalAddClassRef);
		}

		private async void GetClassById(MyClassDto myclass)
		{
			await OpenModal(MyVariablesApp.ModalAddClassRef);
			_idClass = myclass.IdClass;
			_myClass.IdClass = myclass.IdClass;
			_myClass.TitleOne = myclass.TitleOne;
			_myClass.TitleTwo = myclass.TitleTwo;
			_myClass.InfoClass = myclass.InfoClass;
			_myClass.CodeClass = myclass.CodeClass;
			_myClass.LinkRef = myclass.LinkRef;
			_myClass.IdImageClass = myclass.IdImageClass;
			_myClass.IdCourse = myclass.IdCourse;
			_myClass.IdType = myclass.IdType;
		}

		private async Task UpLoadImage()
		{
			var newImage = new ImagesClassDto
			{
				NameImage = _imagesClass.NameImage,
				ImageUrl = _imagesClass.ImageUrl == null ? "" : _imagesClass.ImageUrl,
				ImageBase64 = MyVariablesApp.ImageBase64 == null ? "" : MyVariablesApp.ImageBase64,
				RefImage = Guid.NewGuid().ToString().ToUpper()
            };
			await CloseModal(MyVariablesApp.ModalAddImageClassRef);
			await ImageClassRepository.PostImageClass(newImage);
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
			return MyVariablesApp.ModalAddClassRef == myModal
				? MyVariablesApp.ModalAddClassRef.Show()
				: MyVariablesApp.ModalAddImageClassRef.Show();
		}

		private Task CloseModal(Modal myModal)
		{
			if (MyVariablesApp.ModalAddClassRef == myModal)
			{
				_myClass.TitleOne = "";
				_myClass.TitleTwo = "";
				_myClass.InfoClass = "";
				_myClass.CodeClass = "";
				_myClass.LinkRef = "";
				_myClass.IdImageClass = 0;
				_myClass.IdCourse = 0;
				_myClass.IdType = 0;
				_idClass = 0;
				_courses.IdCourse = 0;
				ReloadData();
				return MyVariablesApp.ModalAddClassRef.Hide();
			}
			else
			{
				MyVariablesApp.ImageDefault = "/assets/code.svg";
				_imagesClass.NameImage = "";
				_imagesClass.ImageBase64 = "";
				_imagesClass.ImageUrl = "";
				MyVariablesApp.ImageBase64 = null;
				ReloadData();
				return MyVariablesApp.ModalAddImageClassRef.Hide();
			}
		}
	}
}