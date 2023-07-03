namespace Loooong_boy;

public partial class GameScreen : ContentPage
{
	public GameScreen(GameScreenModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}