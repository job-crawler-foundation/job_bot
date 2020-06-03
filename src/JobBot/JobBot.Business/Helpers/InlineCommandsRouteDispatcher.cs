using JobBot.Business.Abstractions;
using JobBot.Business.MessageModels;
using JobBot.Business.MessageModels.InlineCommands;

namespace JobBot.Business.Helpers
{
    public class InlineCommandsRouteDispatcher
    {
        public static IMessage GetMessageInstance(string route)
        {
            if (route.StartsWith("/update"))
                return new UpdatePreferencesMessage();
            return new InitialMessage();
        }
    }
}