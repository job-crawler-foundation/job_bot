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

            if (route.StartsWith("/disable"))
                return new DisableSearchMessage();

            if (route.StartsWith("/enable"))
                return new EnableSearchMessage();

            return new InitialMessage();
        }
    }
}