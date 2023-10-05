using BirdCalls.MVVM.ViewModels;

namespace BirdCalls.MVVM.Views;

public partial class BirdsDetailPage : ContentPage
{
	public BirdsDetailPage(BirdsDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}