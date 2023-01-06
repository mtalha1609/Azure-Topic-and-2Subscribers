using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace WeatherDataProcessor
{
    public static class Function1
    {
  
        //DEPENDENCY INJECTION USING STATIC METHOD 

        [FunctionName("Function1")]
        public static void Run([ServiceBusTrigger("weather-forecast-added", "send-email", Connection = "WeatherforecastConnection")]string mySbMsg,ILogger logger)
        {
            logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
