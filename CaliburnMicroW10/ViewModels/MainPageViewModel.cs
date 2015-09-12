using System;
using Caliburn.Micro;

namespace CaliburnMicroW10.ViewModels
{
    public class MainPageViewModel : Screen
    {
        private readonly INavigationService _navigationService;
        private string _name = String.Empty;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public string Title
        {
            get { return "Título de nuestra vista"; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => CanNavigate);
            }
        }

        public bool CanNavigate
        {
            get { return Name.Equals("jesus"); }
        }

        public void Navigate()
        {
            _navigationService.NavigateToViewModel<SecondPageViewModel>();
        }
    }
}