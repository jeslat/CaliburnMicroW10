using Windows.UI.Core;
using Caliburn.Micro;

namespace CaliburnMicroW10.ViewModels
{
    public class ViewModelBase : Screen
    {
        protected readonly INavigationService NavigationService;

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                NavigationService.CanGoBack ? AppViewBackButtonVisibility.Visible :
                AppViewBackButtonVisibility.Collapsed;
        }
    }
}