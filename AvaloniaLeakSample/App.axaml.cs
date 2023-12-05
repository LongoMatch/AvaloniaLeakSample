using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AvaloniaLeakSample;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public MainWindow? MainWindow { get; private set; }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            MainWindow = new MainWindow();
            MainWindow.SetPanel(new View1());
            desktop.MainWindow = MainWindow;
        }

        base.OnFrameworkInitializationCompleted();
    }
}