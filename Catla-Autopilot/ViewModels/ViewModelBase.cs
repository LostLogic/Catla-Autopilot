using Catla_Autopilot.Stores;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace Catla_Autopilot.ViewModels;

[ObservableObject]
public partial class ViewModelBase
{
    [ObservableProperty]
    private string? _pageTitle;

    protected readonly NavigationStore _navigationStore;
    public RelayCommand<ViewList> NavigateViewCommand { get; }

    private void NavigateView(ViewList TargetView)
    {
        switch (TargetView)
        {
            case ViewList.About:
                _navigationStore.CurrentViewModel = new AboutViewModel(_navigationStore);
                OnPropertyChanged(nameof(_navigationStore.CurrentViewModel));
                break;
            case ViewList.Config:
                _navigationStore.CurrentViewModel = new ConfigViewModel(_navigationStore);
                OnPropertyChanged(nameof(_navigationStore.CurrentViewModel));
                break;
            case ViewList.Gather:
                _navigationStore.CurrentViewModel = new GatherViewModel(_navigationStore);
                OnPropertyChanged(nameof(_navigationStore.CurrentViewModel));
                break;
            default:
                break;
        }
    }

    public ViewModelBase(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        NavigateViewCommand = new RelayCommand<ViewList>(NavigateView);
    }
}

public enum ViewList
{
    Gather,About,Config
}