using System.Collections.ObjectModel;
using Windows.UI.Popups;
using Caliburn.Micro;

namespace CaliburnMicroW10.ViewModels
{
    public class SecondPageViewModel : Screen
    {
        private string _selectedItem;

        public ObservableCollection<string> Items
        {
            get
            {
                return new ObservableCollection<string>(new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12" });
            }
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                new MessageDialog(_selectedItem).ShowAsync();
            }
        }
    }
}