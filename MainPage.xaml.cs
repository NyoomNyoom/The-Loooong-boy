﻿namespace Loooong_boy;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		await Shell.Current.GoToAsync(nameof(GameScreen));
	}

	private async void OnCharPickClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(GameScreen));
	}
}

