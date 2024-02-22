using CommunityToolkit.Mvvm.Messaging;
using IconTintColorBehaviorBug.Models;

namespace IconTintColorBehaviorBug;

public partial class App
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        
        WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, (r, m) => { ChangeTheme(m.Value); });
    }
    
    private void ChangeTheme(string theme)
    {
        UserAppTheme = theme switch
        {
            "Light" => AppTheme.Light,
            "Dark" => AppTheme.Dark,
            _ => AppTheme.Unspecified
        };
    }
}