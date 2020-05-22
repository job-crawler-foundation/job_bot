using JobBot.Business.Abstractions;
using JobBot.Business.Consts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace JobBot.Business.MessageModels
{
    public class InitialMessage : IMessage
    {
        public async Task Reply(TelegramBotClient client, Update hook)
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData(CallbackData.Settings.Text),
                    InlineKeyboardButton.WithCallbackData(CallbackData.About.Text),
                },
            });
            await client.SendTextMessageAsync(
                new ChatId(
                    hook.Message.Chat.Id), "Hello it't job scrapper foundation bot",replyMarkup: inlineKeyboard);
        }
    }
}
