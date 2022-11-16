using Catla_Autopilot.Stores;

namespace Catla_Autopilot.ViewModels;

public partial class GatherViewModel : ViewModelBase
{
    public GatherViewModel(NavigationStore navigationStore) : base(navigationStore)
    {
        PageTitle = "Gather Page";
    }
}
