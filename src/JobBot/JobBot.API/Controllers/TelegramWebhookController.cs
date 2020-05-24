using JobBot.Business.Abstractions;
using Microsoft.AspNetCore.Mvc;
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

        public TelegramWebhookController(ITelegramHookProcessService telegramResponseService)
        {
            _telegramResponseService = telegramResponseService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update hook)
        {
            await _telegramResponseService.Process(hook);

            return Ok();
        }
    }
}
