using BirdCalls.MVVM.ViewModels;

namespace BirdCalls.MVVM.Views;

public partial class BirdsHomePage : ContentPage
{
	public BirdsHomePage(BirdsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}