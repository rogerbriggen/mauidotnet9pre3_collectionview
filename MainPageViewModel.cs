using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace mauidotnet9pre3_collectionview
{
    public class MainPageViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; set; }

        public ICommand ItemClickedCommand { get; set; }

        public MainPageViewModel()
        {
            Items = new ObservableCollection<ItemViewModel>
            {
                // Add your items here
            };

            ItemClickedCommand = new Command<ItemViewModel>(OnItemClicked);
        }

        private void OnItemClicked(ItemViewModel item)
        {
            Debug.WriteLine($"Item clicked: {item.Name}");
        }
    }

    public class ItemViewModel
    {
        public string Name { get; set; } = string.Empty;
    }
}
