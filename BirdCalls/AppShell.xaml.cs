using BirdCalls.MVVM.Views;

namespace BirdCalls;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(BirdsDetailPage), typeof(BirdsDetailPage));
    }
}
