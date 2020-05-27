using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace JobBot.Business.Helpers
{
    public static class UpdateMessageExtensions { 
        public static long ChatId(this Update hook)
        {
            if (hook.Type == UpdateType.Message)
                return hook.Message.Chat.Id;
            if (hook.Type == UpdateType.CallbackQuery)
                return hook.CallbackQuery.Message.Chat.Id;

            return default;
        }
    }
}
