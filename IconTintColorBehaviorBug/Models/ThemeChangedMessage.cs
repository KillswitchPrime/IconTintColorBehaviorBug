using CommunityToolkit.Mvvm.Messaging.Messages;

namespace IconTintColorBehaviorBug.Models;

public class ThemeChangedMessage(string value) : ValueChangedMessage<string>(value);