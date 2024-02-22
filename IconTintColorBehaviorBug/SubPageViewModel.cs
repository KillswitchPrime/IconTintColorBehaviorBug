using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using IconTintColorBehaviorBug.Models;

namespace IconTintColorBehaviorBug;

public partial class SubPageViewModel: ObservableObject, IQueryAttributable
{
    [ObservableProperty] private ObservableCollection<IconTemplate> _iconTemplates = [];

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var iconGroup = query["group"] as IconGroup;
        
        foreach(var iconTemplate in iconGroup.IconTemplates)
        {
            IconTemplates.Add(new IconTemplate
            {
                IconUrl = "dotnet_bot.png"
            });
        }
        
        OnPropertyChanged("SelectedIconGroup");
        OnPropertyChanged("IconTemplates");
    }
}