using HamburgesasSQLite_AlexQuintana.Data;

namespace HamburgesasSQLite_AlexQuintana;

public partial class App : Application
{
	public static BurgerDatabaseAQ BurgerRepo { get; set; }
	public App(BurgerDatabaseAQ repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		BurgerRepo = repo;
	}
}
