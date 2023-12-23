namespace ProgrammingCode.Helpers
{
	public class LocalStorageDataApp
	{
		public static readonly string KeyToken = "token";
		public static readonly string KeyUser = "user";
		public static readonly string KeyIdUser = "idUser";
		public static readonly string KeyTheme = "theme";
		public static readonly string KeyLanguage = "language";

		public static void SetItem(string key, string value) => SecureStorage.Default.SetAsync(key, value);

		public static async Task<string> GetItem(string key) => await SecureStorage.Default.GetAsync(key);

		public static void RemoveItem() => SecureStorage.RemoveAll();
	}
}