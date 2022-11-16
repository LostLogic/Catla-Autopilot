using Catla_Autopilot.Stores;

namespace Catla_Autopilot.ViewModels;

partial class AboutViewModel : ViewModelBase
{
    public AboutViewModel(NavigationStore navigationStore) : base(navigationStore)
    {
        PageTitle = "About Page";
    }
}
