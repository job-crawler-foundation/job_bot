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

        public Task Process(Update hook)
        {
            switch (hook.Type)
            {
                case UpdateType.Message:
                    break;
                case UpdateType.CallbackQuery:
                    var message = new CallbackQueryService().Handle(hook);
                    message.Reply(_telegramBotClient, hook);
                    break;
                default:
                    break;
            }
            throw new NotImplementedException();
        }

        public string Match(bool a,bool b)
        {
            return (a, b) switch
            {
                (true, true) => "aa",

                _ => "zz"
            };
        }
    }
}
