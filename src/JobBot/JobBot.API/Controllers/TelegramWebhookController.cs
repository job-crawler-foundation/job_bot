using JobBot.Business.Abstractions;
using JobBot.Business.Helpers;
using JobBot.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JobBot.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelegramWebhookController: ControllerBase
    {
        private readonly ITelegramHookProcessService _telegramResponseService;

        private readonly JobBotDbContext _dbContext;

        public TelegramWebhookController(ITelegramHookProcessService telegramResponseService, JobBotDbContext context)
        {
            _telegramResponseService = telegramResponseService;

            _dbContext = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update hook)
        {
            var userExist = _dbContext.Users.FirstOrDefault(x => x.ChatId == hook.ChatId());

            if (userExist == null)
            {
                var user = new JobBot.Data.Entities.User()
                {
                    ChatId = hook.ChatId(),
                    SearchEnabled = true
                };
                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();
            }

            await _telegramResponseService.Process(hook);

            return Ok();
        }
    }
}
