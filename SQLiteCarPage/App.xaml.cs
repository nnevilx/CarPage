using SQLiteCarPage.MVVM.Models;
using SQLiteCarPage.Repository;

namespace SQLiteCarPage;

public partial class App : Application
{
	public static CarRepository _carRepo {get ; set;}
	public App(CarRepository carRepo)
	{
		InitializeComponent();

		_carRepo = carRepo;

		//MainPage = new AppShell();
		MainPage = new CarPage();
	}
}