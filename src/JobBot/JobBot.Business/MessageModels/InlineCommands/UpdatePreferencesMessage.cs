using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.MessageModels.InlineCommands
{
    public class UpdatePreferencesMessage : IMessage
    {
        private const string UpdatePreferencesCommand = "/update";

        public async Task Reply(TelegramBotClient client, Update hook, JobBotDbContext ctx = null)
        {
            var user = await ctx.Users.FirstOrDefaultAsync(x => x.ChatId == hook.ChatId());

            var preferences = hook.Message.Text.TrimStart(UpdatePreferencesCommand.ToCharArray()).Trim();
            user.Preferences = preferences;

            ctx.Users.Update(user);
            await ctx.SaveChangesAsync();
            await client.SendTextMessageAsync(hook.ChatId(), "preferences changed to " + preferences);
        }
    }
}
