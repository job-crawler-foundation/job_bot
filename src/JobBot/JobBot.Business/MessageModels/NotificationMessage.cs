using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace JobBot.Business.MessageModels
{
    public class NotificationMessage : IMessage
    {
        public async Task Reply(TelegramBotClient client, Update hook)
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData("On","Notification:On"),
                    InlineKeyboardButton.WithCallbackData("Off","Notification:Off"),
                },
                new[]
                {
                       InlineKeyboardButton.WithCallbackData("Home"),
                }
            });
            await client.SendTextMessageAsync(hook.ChatId(), "Here you can manage notifications settings , turn-off or turn-on", replyMarkup: inlineKeyboard);
        }
    } 
}