using JobBot.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

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
            throw new NotImplementedException();
        }
    }
}
