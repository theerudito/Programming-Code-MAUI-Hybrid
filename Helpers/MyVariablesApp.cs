using Blazorise;

namespace ProgrammingCode.Helpers
{
    public class MyVariablesApp
    {
        public static string _languageApp = "EN";
        public static string _themeApp = "Dark";
        public static string IdUser;
        public static Modal ModalCourseList;
        public static Modal ModalAddCourseRef;
        public static Modal ModalAddImageRef;
        public static Modal ModalAddClassRef;
        public static Modal ModalAddImageClassRef;
        public static string ImageDefault = "/assets/code.svg";
        public static readonly string ImageRef = Guid.NewGuid().ToString().ToUpper();
        public static string ImageBase64 = "";
        public static int IdCoursesTypes = 1;
        public static bool _isSeaching = false;
        public static string _searchData = "";
        public static string _displayInput = "d-flex";
    }
}