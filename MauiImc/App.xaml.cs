using MauiImc.MVVM.Views;

namespace MauiImc;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new NavigationPage(new ImcView());
	}
}
