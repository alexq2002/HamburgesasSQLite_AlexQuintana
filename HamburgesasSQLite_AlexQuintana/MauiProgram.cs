using HamburgesasSQLite_AlexQuintana.Data;

namespace HamburgesasSQLite_AlexQuintana;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        string dbPath = FileAccessHelper.GetLocalFilePath("burger.db3");
		builder.Services.AddSingleton<BurgerDatabaseAQ>(s => ActivatorUtilities.CreateInstance<BurgerDatabaseAQ>(s, dbPath));
        return builder.Build();
	}
}
