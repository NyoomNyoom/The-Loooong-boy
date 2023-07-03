namespace Loooong_boy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(GameScreen), typeof(GameScreen));
	}
}
