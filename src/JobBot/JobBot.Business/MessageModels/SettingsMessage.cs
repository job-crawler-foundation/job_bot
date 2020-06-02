using JobBot.Business.Abstractions;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using JobBot.Business.Helpers;
using JobBot.Data;

namespace JobBot.Business.MessageModels
{
    public class SettingsMessage : IMessage
    {
        public async Task Reply(TelegramBotClient client,Update hook, JobBotDbContext ctx = null)
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData("Preferences"),
                    InlineKeyboardButton.WithCallbackData("Notifications"),
                },
                new[]
                {
                       InlineKeyboardButton.WithCallbackData("Home"),
                }
            }); ;
            await client.SendTextMessageAsync(hook.ChatId(),"its settings", replyMarkup: inlineKeyboard);
        }
    }
}
