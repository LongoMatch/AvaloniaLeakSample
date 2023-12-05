using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaLeakSample;

public partial class View2 : UserControl
{
	public View2 ()
	{
		InitializeComponent ();
	}
	
	~View2()
	{
		Console.WriteLine ("There is no leak on view 2");
	}

	protected override void OnInitialized ()
	{
		base.OnInitialized ();
		NestedControl.IsVisible = false;
		// OtherButton.IsVisible = false;
	}

	public void Button_Click (object sender, RoutedEventArgs args)
	{
		(Avalonia.Application.Current as App).MainWindow.SetPanel (new View1 ());
	}
}