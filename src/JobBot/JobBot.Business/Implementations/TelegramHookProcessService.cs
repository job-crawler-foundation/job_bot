using JobBot.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace JobBot.Business.Implementations
{
    public class TelegramHookProcessService : ITelegramHookProcessService
    {
        private readonly TelegramBotClient _telegramBotClient;

        public TelegramHookProcessService(TelegramBotClient telegramBotClient)
        {
            _telegramBotClient = telegramBotClient;
        }

        public async Task Process(Update hook)
        {
            switch (hook.Type)
            {
                case UpdateType.Message:
                    var initMessage = new InitialMessageService().Handle(hook);
                    await initMessage.Reply(_telegramBotClient, hook);
                    break;
                case UpdateType.CallbackQuery:
                    var message = new CallbackQueryService().Handle(hook);
                    await message.Reply(_telegramBotClient, hook);
                    break;
                default:
                    break;
            }
        }
    }
}
