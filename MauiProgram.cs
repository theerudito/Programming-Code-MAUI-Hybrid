using Blazorise;
using Blazorise.Bootstrap;
using Microsoft.Extensions.Logging;
using ProgrammingCode.Data;
using ProgrammingCode.Service.Another;
using ProgrammingCode.Service.Interface;
using ProgrammingCode.Service.Repository;
using ProgrammingCode.Services.Another;
using ProgrammingCode.Services.Repository;

namespace ProgrammingCode
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services
			 .AddBlazorise(options =>
			 {
				 options.Immediate = true;
			 })
			 .AddBootstrapProviders();


            builder.Services.AddSingleton<ApplicationContextDB>();

			builder.Services.AddSingleton<LanguageService>();
			builder.Services.AddSingleton<ThemeService>();
			builder.Services.AddSingleton<InternetService>();

			builder.Services.AddSingleton<IAuth, AuthRepository>();
			builder.Services.AddSingleton<IMenu, MenuRepository>();
			builder.Services.AddSingleton<ICourse, CourseRepository>();
			builder.Services.AddSingleton<IMyApplication, ApplicationRepository>();

			builder.Services.AddSingleton<CourseTypesRepository>();
			builder.Services.AddSingleton<AuthService>();
			builder.Services.AddSingleton<ImagesCoursesRepository>();
			builder.Services.AddSingleton<ImagesClassRepository>();
			builder.Services.AddSingleton<RoleRepository>();
			builder.Services.AddSingleton<MyClassRepository>();
			builder.Services.AddSingleton<My_Class_Repository>();
            builder.Services.AddSingleton<DataUserRepository>();

            builder.Services.AddMauiBlazorWebView();


#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
			builder.Logging.AddDebug();
#endif

            return builder.Build();
		}
	}
}