namespace IconTintColorBehaviorBug.Services;

public class NavigationService : INavigationService
{
    public Task InitializeAsync()
    {
        return Task.CompletedTask;
        // return NavigateToAsync(
        //     string.IsNullOrEmpty(_settingsService.AuthAccessToken)
        //         ? "//Login"
        //         : "//Main/Catalog");
    }

    public Task NavigateToAsync(string route, IDictionary<string, object>? routeParameters = null)
    {
        var shellNavigation = new ShellNavigationState(route);

        return routeParameters == null
            ? Shell.Current.GoToAsync(shellNavigation)
            : Shell.Current.GoToAsync(shellNavigation, routeParameters);
    }

    public Task PopAsync()
    {
        return Shell.Current.GoToAsync("..");
    }
}