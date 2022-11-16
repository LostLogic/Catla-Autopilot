using Catla_Autopilot.Stores;

namespace Catla_Autopilot.ViewModels;

public partial class ConfigViewModel : ViewModelBase
{
    public ConfigViewModel(NavigationStore navigationStore) : base(navigationStore)
    {
        PageTitle = "Config Page";
    }
}
