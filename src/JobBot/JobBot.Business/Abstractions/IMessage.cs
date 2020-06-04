using JobBot.Data;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.Abstractions
{
    public interface IMessage
    {
        Task Reply(TelegramBotClient client, Update hook, JobBotDbContext ctx = null);
    }
}
