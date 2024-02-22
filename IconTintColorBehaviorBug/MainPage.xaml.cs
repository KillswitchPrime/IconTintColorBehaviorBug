namespace IconTintColorBehaviorBug;

public partial class MainPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        MemoryLabel.Text = $"Memory: {GC.GetTotalMemory(false) / 1024} KB";
    }
}