using JobBot.Business.Abstractions;
using JobBot.Business.MessageModels;
using JobBot.Business.MessageModels.InlineCommands;

namespace JobBot.Business.Helpers
{
    public class InlineCommandsRouteDispatcher
    {
        public static IMessage GetMessageInstance(string route)
        {
            switch (route)
            {
                case "/update":
                    return new UpdatePreferencesMessage();
                default:
                    return new InitialMessage();
            }
        }
    }
}