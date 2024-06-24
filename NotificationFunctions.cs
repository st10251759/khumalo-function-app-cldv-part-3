using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace KhumaloFunction
{
    public static class NotificationFunctions
    {
        [FunctionName("SendOrderPlacedNotification")]
        public static async Task SendOrderPlacedNotification([Microsoft.Azure.WebJobs.Extensions.DurableTask.ActivityTrigger] OrderDetails orderDetails, ILogger log)
        {
            log.LogInformation($"Sending order placed notification for order {orderDetails.OrderId}.");
            // Logic to send order placed notification via Azure Event Grid
        }

        [FunctionName("SendOrderProcessedNotification")]
        public static async Task SendOrderProcessedNotification([Microsoft.Azure.WebJobs.Extensions.DurableTask.ActivityTrigger] OrderDetails orderDetails, ILogger log)
        {
            log.LogInformation($"Sending order processed notification for order {orderDetails.OrderId}.");
            // Logic to send order processed notification via Azure Event Grid
        }

        [FunctionName("SendOrderShippedNotification")]
        public static async Task SendOrderShippedNotification([Microsoft.Azure.WebJobs.Extensions.DurableTask.ActivityTrigger] OrderDetails orderDetails, ILogger log)
        {
            log.LogInformation($"Sending order shipped notification for order {orderDetails.OrderId}.");
            // Logic to send order shipped notification via Azure Event Grid
        }
    }
}
