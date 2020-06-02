using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Data;
using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace JobBot.Business.MessageModels
{
    public class PreferencesMessage : IMessage
    {
        public async Task Reply(TelegramBotClient client, Update hook, JobBotDbContext ctx = null)
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                       InlineKeyboardButton.WithCallbackData("Home"),
                }
            }); ;
            await client.SendTextMessageAsync(hook.ChatId(), "To setup preferences tap /update <fill with lang>", replyMarkup: inlineKeyboard);
        }
    }
}
