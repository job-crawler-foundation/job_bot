using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using Telegram.Bot.Types;

namespace JobBot.Business.Implementations
{
    public class CallbackQueryService
    {
        public IMessage Handle(Update hook)
        {
            return RouteDispatcher.GetMessageInstance(hook.CallbackQuery.Data);
        }
    }
}