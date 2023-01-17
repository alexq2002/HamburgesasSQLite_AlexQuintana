using HamburgesasSQLite_AlexQuintana.Models;

namespace HamburgesasSQLite_AlexQuintana.Views;

public partial class BurgerListPageAQ : ContentPage
{
    public BurgerListPageAQ()
    {
        InitializeComponent();
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        List<BurgerAQ> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
        await Shell.Current.GoToAsync(nameof(BurgerItemPageAQ));
        //Colocar en este formato el GoToAsync de el metodo OnSaveClicked de BurgerItemPageAQ.cs
        //await Shell.Current.GoToAsync(nameof(BurgerItemPageAQ));
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<BurgerAQ> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
}