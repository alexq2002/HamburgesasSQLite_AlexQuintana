
using HamburgesasSQLite_AlexQuintana.Data;
using HamburgesasSQLite_AlexQuintana.Models;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace HamburgesasSQLite_AlexQuintana.Views;

[QueryProperty("Item", "Item")]
public partial class BurgerItemPageAQ : ContentPage
{
    string ImagePath = null;
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
        Item.PortadaPath = ImagePath;
        Item.HoraYFechaActual = DateTime.Parse(HoraYFechaAct.Text);
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {
        if (App.BurgerRepo.DeleteItem(Item) != -639)
        {
            App.BurgerRepo.DeleteItem(Item);
            Shell.Current.GoToAsync("..");
        }
        else
        { }
    }

    private async void UploadImageClicked(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "Suba una imagen",
            FileTypes = FilePickerFileType.Images
        });
        if (result == null)
            return;

        var stream = await result.OpenReadAsync();
        Imagen.Source = ImageSource.FromStream(() => stream);
        ImagePath = result.FullPath;
    }
}