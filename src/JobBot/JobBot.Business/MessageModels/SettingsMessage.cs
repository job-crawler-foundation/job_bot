using JobBot.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using JobBot.Business.Helpers;

namespace JobBot.Business.MessageModels
{
    public class SettingsMessage : IMessage
    {
        public async Task Reply(TelegramBotClient client,Update hook)
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
           {
                new []
                {
                    InlineKeyboardButton.WithCallbackData("Preferences"),
                    InlineKeyboardButton.WithCallbackData("Notifications"),
                    InlineKeyboardButton.WithCallbackData("On/Off")
                },
                new[]
                {
                       InlineKeyboardButton.WithCallbackData("Home"),
                }
            }); ;
            await client.SendTextMessageAsync(hook.ChatId(),"its settings",replyMarkup: inlineKeyboard);
        }
    }
}
