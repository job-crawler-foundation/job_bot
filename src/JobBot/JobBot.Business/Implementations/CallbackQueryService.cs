using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace JobBot.Business.Implementations
{
    public class CallbackQueryService
    {
        public async Task Handle(Update hook)
        {
            switch (hook.CallbackQuery.Data)
            {
                case "Settings":
                    break;
                case "About":
                    break;

            }
        }
    }
}
