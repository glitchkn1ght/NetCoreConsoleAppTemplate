using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace NetCoreConsoleAppTemplate.Application
{
    public class App
    {
        private readonly ILogger<App> Logger;

        public App(ILogger<App> logger)
        {
            this.Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Run(string[] args)
        {
            try
            {
                this.Logger.LogInformation($"Operation=Run(App), Status=Success, Message=Application  has started successfully.");
            }

            catch (Exception ex)
            {
                this.Logger.LogError($"Operation=RunGame(App), Status=Failure, Message={ex.Message}");
            }
        }
    }
}