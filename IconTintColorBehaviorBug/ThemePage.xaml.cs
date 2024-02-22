using CommunityToolkit.Mvvm.Messaging;
using IconTintColorBehaviorBug.Models;

namespace IconTintColorBehaviorBug;

public partial class ThemePage : ContentPage
{
    public ThemePage(ThemePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void RadioButtonLight_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        WeakReferenceMessenger.Default.Send(new ThemeChangedMessage("Light"));
    }

    private void RadioButtonDark_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        WeakReferenceMessenger.Default.Send(new ThemeChangedMessage("Dark"));
    }
}