using JobBot.Business.Abstractions;
using JobBot.Business.MessageModels;

namespace JobBot.Business.Helpers
{
    public static class RouteDispatcher
    {
        public static IMessage GetMessageInstance(string route)
        {
            switch (route)
            {
                case "Settings":
                    return new SettingsMessage();
                case "Home":
                    return new InitialMessage();
                case "About":
                    return new AboutMessage();
                case "Notifications":
                    return new NotificationMessage();
                case "Preferences":
                    return new PreferencesMessage();
                default:
                    return new InitialMessage();
            }
        }
    }
}
