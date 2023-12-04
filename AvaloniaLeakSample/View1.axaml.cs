using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaLeakSample;

public partial class View1 : UserControl
{
	public View1 ()
	{
		InitializeComponent ();
	}
	
	~View1()
	{
		Console.WriteLine ("There is no leak on view 1");
	}
	
	void Button_OnClick (object? sender, RoutedEventArgs e)
	{
		GuiToolkit.Current.MainWindow.SetPanel (new View2 ());
	}
}