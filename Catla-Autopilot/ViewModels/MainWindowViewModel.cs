using Catla_Autopilot.Stores;
using System.ComponentModel;

namespace Catla_Autopilot.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel(NavigationStore navigationStore) : base(navigationStore)
    {
        _navigationStore.CurrentViewModel.PropertyChanged += OnCurrentViewModelChanged;
    }

    private void OnCurrentViewModelChanged(object? sender, PropertyChangedEventArgs e)
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }

    public ViewModelBase CurrentViewModel
    {
        get
        {
            _navigationStore.CurrentViewModel.PropertyChanged += OnCurrentViewModelChanged;
            return _navigationStore.CurrentViewModel;
        }
    }
}
