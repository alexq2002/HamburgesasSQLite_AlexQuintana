using HamburgesasSQLite_AlexQuintana.Data;
using HamburgesasSQLite_AlexQuintana.Models;

namespace HamburgesasSQLite_AlexQuintana.Views;

public partial class BurgerItemPageAQ : ContentPage
{
    BurgerAQ Item = new BurgerAQ();
    bool _flag;


    public BurgerItemPageAQ()
	{
		InitializeComponent();
	}

	private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
        _flag = e.Value;
    }

    private void OnSaveClicked(object sender, EventArgs e)
	{
        Item.Name = nameB.Text;
        Item.Description = descB.Text;
        Item.WithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("..");
    }
}