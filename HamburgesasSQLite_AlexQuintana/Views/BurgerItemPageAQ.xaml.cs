using HamburgesasSQLite_AlexQuintana.Data;
using HamburgesasSQLite_AlexQuintana.Models;
using Microsoft.Maui.Controls;

namespace HamburgesasSQLite_AlexQuintana.Views;

[QueryProperty("Item", "Item")]
public partial class BurgerItemPageAQ : ContentPage
{
    public BurgerAQ Item
    {
        get => BindingContext as BurgerAQ;
        set => BindingContext = value;
    }

    public BurgerItemPageAQ()
	{
		InitializeComponent();
	}

    private void OnSaveClicked(object sender, EventArgs e)
	{
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("..");
    }
}