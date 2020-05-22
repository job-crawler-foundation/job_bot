using JobBot.Business.Abstractions;
using JobBot.Business.MessageModels;
using Telegram.Bot.Types;

namespace JobBot.Business.Implementations
{
    public class CallbackQueryService
    {
        public IMessage Handle(Update hook)
        {
            switch (hook.CallbackQuery.Data)
            {
                case "Settings":
                    return new SettingsMessage();
                case "Home":
                    return new InitialMessage();
                case "About":
                    return new AboutMessage();
            }
            return null;
        }
    }
}
