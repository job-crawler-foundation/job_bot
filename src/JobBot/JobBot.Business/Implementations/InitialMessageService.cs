using JobBot.Business.Abstractions;
using JobBot.Business.MessageModels;
using Telegram.Bot.Types;

namespace JobBot.Business.Implementations
{
    public class InitialMessageService
    {
        public IMessage Handle(Update hook)
        {
            return new InitialMessage();
        }
    }
}
