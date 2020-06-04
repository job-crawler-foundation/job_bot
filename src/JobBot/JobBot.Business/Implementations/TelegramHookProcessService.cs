using JobBot.Business.Abstractions;
using JobBot.Data;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace JobBot.Business.Implementations
{
    public class TelegramHookProcessService : ITelegramHookProcessService
    {
        private readonly TelegramBotClient _telegramBotClient;

        private readonly JobBotDbContext _ctx;

        public TelegramHookProcessService(TelegramBotClient telegramBotClient,
            JobBotDbContext ctx)
        {
            _telegramBotClient = telegramBotClient;

            _ctx = ctx;
        }

        public async Task Process(Update hook)
        {
            switch (hook.Type)
            {
                case UpdateType.Message:
                    var initMessage = new InitialMessageService().Handle(hook);
                    await initMessage.Reply(_telegramBotClient, hook, _ctx);
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
