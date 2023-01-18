using HamburgesasSQLite_AlexQuintana.Models;

namespace HamburgesasSQLite_AlexQuintana.Views;

public partial class BurgerListPageAQ : ContentPage
{
    public BurgerListPageAQ()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public void OnItemAddedAQ(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BurgerItemPageAQ), true, new Dictionary<string, object>
        {
            ["Item"] = new BurgerAQ()
        });
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<BurgerAQ> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPageAQ), true, new Dictionary<string, object>
        {
            ["Item"] = (BurgerAQ)e.CurrentSelection.FirstOrDefault()
        });
    }
}
