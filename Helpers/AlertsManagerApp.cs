namespace ProgrammingCode.Helpers
{
    public class AlertsManagerApp
    {
        public static async Task ShowAlert(string title, string message, string cancel)
        {
            await App.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public static async Task<bool> ShowAlert(string title, string message, string accept, string cancel)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}