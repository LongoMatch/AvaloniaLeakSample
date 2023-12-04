using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AvaloniaLeakSample;

public partial class App : Application
{
	public override void Initialize ()
	{
		AvaloniaXamlLoader.Load (this);
	}

	public override void OnFrameworkInitializationCompleted ()
	{
		GuiToolkit.Current = new GuiToolkit ();
		
		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
			GuiToolkit.Current.MainWindow = new MainWindow ();
			GuiToolkit.Current.MainWindow.SetPanel (new View1 ());
			desktop.MainWindow = GuiToolkit.Current.MainWindow;
		}

		base.OnFrameworkInitializationCompleted ();
	}
}