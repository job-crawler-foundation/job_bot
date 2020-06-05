using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.Business.MessageModels.InlineCommands
{
    public class EnableSearchMessage : IMessage
    {
        private const string EnableSearchCommand = "/enable";

        public async Task Reply(TelegramBotClient client, Update hook, JobBotDbContext ctx = null)
        {
            var user = await ctx.Users.FirstOrDefaultAsync(x => x.ChatId == hook.ChatId());

            user.SearchEnabled = true;

            ctx.Users.Update(user);

            await ctx.SaveChangesAsync();
        }
    }
}
