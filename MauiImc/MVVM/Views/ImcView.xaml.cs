using MauiImc.MVVM.ModelViews;

namespace MauiImc.MVVM.Views;

public partial class ImcView : ContentPage
{
	public ImcView()
	{
		InitializeComponent();
		BindingContext = new ImcViewModel();
	}
}