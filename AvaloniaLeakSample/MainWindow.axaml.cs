using Avalonia.Controls;

namespace AvaloniaLeakSample;

public partial class MainWindow : Window
{
	UserControl? _currentPanel;
	
	public MainWindow ()
	{
		InitializeComponent ();
		_currentPanel = null;
	}
	
	public void SetPanel (UserControl panel)
	{
		if (_currentPanel != null) {
			_currentPanel = null;
		}
		
		_currentPanel = panel;
		ContentPanel.Content = _currentPanel;
	}
}