using JobBot.Data;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JobBot.API.HostedServices
{
    public class JobHostedService : BackgroundService
    {
        private readonly JobBotDbContext _jobBotDbContext;

        public JobHostedService(JobBotDbContext jobBotDbContext)
        {
            _jobBotDbContext = jobBotDbContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Run(()=> Console.WriteLine("lorem ipsum"));       
        }
    }
}
