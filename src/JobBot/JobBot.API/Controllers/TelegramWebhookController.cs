using JobBot.Business.Abstractions;
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
        private readonly ITelegramHookProcessService _telegramResponseService;

        private readonly TelegramBotClient _botClient;

        public TelegramWebhookController(TelegramBotClient botClient, ITelegramHookProcessService telegramResponseService)
        {
            _botClient = botClient;

            _telegramResponseService = telegramResponseService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update hook)
        {
            await _telegramResponseService.Process(hook);

            //var inlineKeyboard = new InlineKeyboardMarkup(new[]
            //   {
            //        // first row
            //        new []
            //        {
            //            InlineKeyboardButton.WithCallbackData("Settings", "Settings"),
            //            InlineKeyboardButton.WithCallbackData("About", "About"),
            //        },
            //    });
            //await _botClient.SendTextMessageAsync(
            //    new ChatId(data.Message.Chat.Id), "hello world",
            //    replyMarkup:inlineKeyboard);
            return Ok();
        }
    }
}
