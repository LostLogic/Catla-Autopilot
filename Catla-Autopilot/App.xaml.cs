using Catla_Autopilot.ViewModels;
using System.Windows;

namespace Catla_Autopilot;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow = new MainWindow()
        {
            DataContext = new MainWindowViewModel(new Stores.NavigationStore())
        };

        MainWindow.Show();

        base.OnStartup(e);
    }
}
