using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Business.MessageModels;
using Telegram.Bot.Types;

namespace JobBot.Business.Implementations
{
    public class InitialMessageService
    {
        public IMessage Handle(Update hook)
        {
            if (hook.Message.Text.StartsWith("/"))
            {
                return InlineCommandsRouteDispatcher.GetMessageInstance(hook.Message.Text);
            }
            return new InitialMessage();
        }
    }
}