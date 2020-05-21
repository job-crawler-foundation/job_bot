using JobBot.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.MessageModels
{
    public class SettingsMessage : IMessage
    {
        public async Task Reply(TelegramBotClient client,Update hook)
        {
            await client.SendTextMessageAsync(new ChatId(hook.CallbackQuery.Message.Chat.Id),"its settings");
        }
    }
}
