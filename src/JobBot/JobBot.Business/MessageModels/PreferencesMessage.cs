using JobBot.Business.Abstractions;
using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.MessageModels
{
    public class PreferencesMessage : IMessage
    {
        public Task Reply(TelegramBotClient client, Update hook)
        {
            throw new NotImplementedException();
        }
    }
}
