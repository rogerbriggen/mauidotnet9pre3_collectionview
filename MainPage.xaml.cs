namespace mauidotnet9pre3_collectionview;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var mainPageViewModel = new MainPageViewModel();    
        mainPageViewModel.Items.Add(new ItemViewModel { Name = "Item 1" });
        mainPageViewModel.Items.Add(new ItemViewModel { Name = "Item 2" });
        mainPageViewModel.Items.Add(new ItemViewModel { Name = "Item 3" });
        BindingContext = mainPageViewModel;
        
    }
}

