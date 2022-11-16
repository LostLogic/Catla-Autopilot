using Catla_Autopilot.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Catla_Autopilot.Stores;

[ObservableObject]
public partial class NavigationStore
{
    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    public NavigationStore()
    {
        CurrentViewModel ??= new GatherViewModel(this);
    }

    public NavigationStore(ViewModelBase currentViewModel)
    {
        CurrentViewModel = currentViewModel;
    }
}
