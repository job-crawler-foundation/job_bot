﻿using JobBot.Business.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace JobBot.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelegramWebhookController: ControllerBase
    {
        private readonly ITelegramHookProcessService _telegramResponseService;

        private readonly IRegistrationService _registrationService;

        public TelegramWebhookController(
            ITelegramHookProcessService telegramResponseService,
            IRegistrationService registrationService)
        {
            _telegramResponseService = telegramResponseService;

            _registrationService = registrationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update hook)
        {
            await _registrationService.EnsureRegistered(hook);

            await _telegramResponseService.Process(hook);

            return Ok();
        }
    }
}
