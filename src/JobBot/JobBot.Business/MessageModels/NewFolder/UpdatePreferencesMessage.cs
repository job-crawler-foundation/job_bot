using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.MessageModels.InlineCommands
{
    public class UpdatePreferencesMessage : IMessage
    {
        private const string UpdatePreferencesCommand = "/update";

        public async Task Reply(TelegramBotClient client, Update hook, JobBotDbContext ctx = null)
        {
            await client.SendTextMessageAsync(hook.ChatId(), "update message fetched");
        }
    }
}
