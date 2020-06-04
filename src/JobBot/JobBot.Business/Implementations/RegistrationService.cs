using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Data;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace JobBot.Business.Implementations
{
    public class RegistrationService : IRegistrationService
    {
        private readonly JobBotDbContext _context;

        public RegistrationService(JobBotDbContext context)
        {
            _context = context;
        }

        public async Task EnsureRegistered(Update hook)
        {
            var userExist = _context.Users.FirstOrDefault(x => x.ChatId == hook.ChatId());

            if (userExist == null)
            {
                var user = new Data.Entities.User()
                {
                    ChatId = hook.ChatId(),
                    SearchEnabled = true
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
