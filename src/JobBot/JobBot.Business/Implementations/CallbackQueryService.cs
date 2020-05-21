using JobBot.Business.Abstractions;
using JobBot.Business.MessageModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace JobBot.Business.Implementations
{
    public class CallbackQueryService
    {
        public IMessage Handle(Update hook)
        {
            switch (hook.CallbackQuery.Data)
            {
                case "Settings":
                    return new SettingsMessage();
                case "About":
                    break;

            }
            return null;
        }
    }
}
