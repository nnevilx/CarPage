
using SQLiteCarPage.MVVM.Models;
using SQLiteCarPage.MVVM.ViewModels;

namespace SQLiteCarPage;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
		BindingContext = new CarPageViewModel();    
	}
}