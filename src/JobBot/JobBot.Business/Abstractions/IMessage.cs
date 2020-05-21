using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.Abstractions
{
    public interface IMessage
    {
        Task Reply(TelegramBotClient client, Update hook);
    }
}
