namespace IconTintColorBehaviorBug;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(SubPage), typeof(SubPage));
        Routing.RegisterRoute(nameof(ThemePage), typeof(ThemePage));
    }
}