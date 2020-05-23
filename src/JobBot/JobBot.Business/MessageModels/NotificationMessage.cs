using JobBot.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.MessageModels
{
    public class NotificationMessage : IMessage
    {
        public Task Reply(TelegramBotClient client, Update hook)
        {
            throw new NotImplementedException();
        }
    }
}
