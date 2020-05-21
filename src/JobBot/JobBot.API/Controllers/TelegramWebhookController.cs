using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace JobBot.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelegramWebhookController: ControllerBase
    {
        private readonly TelegramBotClient _botClient;

        public TelegramWebhookController(TelegramBotClient botClient)
        {
            _botClient = botClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update data)
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
               {
                    // first row
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData("Settings", "Settings"),
                        InlineKeyboardButton.WithCallbackData("About", "About"),
                    },
                });
            await _botClient.SendTextMessageAsync(
                new ChatId(data.Message.Chat.Id), "hello world",
                replyMarkup:inlineKeyboard);
            return Ok();
        }
    }
}
