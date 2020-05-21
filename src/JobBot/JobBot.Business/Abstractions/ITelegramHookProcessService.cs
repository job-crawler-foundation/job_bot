using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace JobBot.Business.Abstractions
{
    public interface ITelegramHookProcessService
    {
        Task Process(Update hook);
    }
}
