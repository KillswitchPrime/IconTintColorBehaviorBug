using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IconTintColorBehaviorBug.Models;
using IconTintColorBehaviorBug.Services;

namespace IconTintColorBehaviorBug;

public partial class MainPageViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;
    
    [ObservableProperty] private ObservableCollection<IconGroup>? _iconGroups = [];
    
    public MainPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        
        var firstIconGroup = new IconGroup { Name="First Group", IconTemplates = [] };
        var secondIconGroup = new IconGroup { Name="Second Group", IconTemplates = [] };

        for (var i = 0; i < 5; i++)
        {
            firstIconGroup.IconTemplates.Add(new IconTemplate
            {
                IconUrl = "dotnet_bot.png"
            });
            secondIconGroup.IconTemplates.Add(new IconTemplate
            {
                IconUrl = "dotnet_bot.png"
            });
        }
        
        IconGroups.Add(firstIconGroup);
        IconGroups.Add(secondIconGroup);
    }

    [RelayCommand]
    private void GoToGroup(IconGroup selectedGroup)
    {
        _navigationService.NavigateToAsync("SubPage", new Dictionary<string, object>{{"group", selectedGroup}});
    }
}