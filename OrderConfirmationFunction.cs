using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace KhumaloFunction
{
    public static class OrderConfirmationFunction
    {
        [FunctionName("ConfirmOrder")]
        public static async Task ConfirmOrder([Microsoft.Azure.WebJobs.Extensions.DurableTask.ActivityTrigger] OrderDetails orderDetails, ILogger log)
        {
            log.LogInformation($"Confirming order {orderDetails.OrderId}.");
            // Logic to confirm order
        }
    }

}
