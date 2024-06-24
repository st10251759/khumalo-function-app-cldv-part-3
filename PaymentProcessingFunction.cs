using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace KhumaloFunction
{
    public static class PaymentProcessingFunction
    {
        [FunctionName("ProcessPayment")]
        public static async Task ProcessPayment([Microsoft.Azure.WebJobs.Extensions.DurableTask.ActivityTrigger] OrderDetails orderDetails, ILogger log)
        {
            log.LogInformation($"Processing payment for order {orderDetails.OrderId}.");
            // Logic to process payment
        }
    }
}
