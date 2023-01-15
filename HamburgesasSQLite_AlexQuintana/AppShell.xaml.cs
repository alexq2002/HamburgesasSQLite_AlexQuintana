using HamburgesasSQLite_AlexQuintana.Views;

namespace HamburgesasSQLite_AlexQuintana;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(BurgerItemPageAQ), typeof(BurgerItemPageAQ));
    }
}
