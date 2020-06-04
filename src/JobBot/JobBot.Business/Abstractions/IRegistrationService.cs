using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace JobBot.Business.Abstractions
{
    public interface IRegistrationService
    {
        Task EnsureRegistered(Update hook);
    }
}
