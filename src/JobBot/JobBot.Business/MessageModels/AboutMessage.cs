using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace JobBot.Business.MessageModels
{
    public class AboutMessage : IMessage
    {
        public async Task Reply(TelegramBotClient client, Update hook, JobBotDbContext ctx = null)
        {
           var inlineKeyboard = new InlineKeyboardMarkup(new[]
           {
              new []
              {
                    InlineKeyboardButton.WithUrl("Github", Consts.Consts.GithubURL)
              },
              new[]
              {
                    InlineKeyboardButton.WithCallbackData("Home"),
              }
           });
           await client.SendPhotoAsync(hook.ChatId(),
                photo: Consts.Consts.LogoURL,
                caption: string.Join("\n", "What is job crawler foundation?", 
                @"It's open source community on github with main goal to crawl as many as possible job websites with programming job and aggregate them."),
                replyMarkup: inlineKeyboard);
        }
    }
}
