using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs;
using Microsoft.DurableTask;
using Microsoft.DurableTask.Client;
using Microsoft.Extensions.Logging;

namespace KhumaloFunction
{
    public static class NotificationWorkflowOrchestrator
    {
        [FunctionName("NotificationWorkflowOrchestrator")]
        public static async Task Run(
            [Microsoft.Azure.WebJobs.Extensions.DurableTask.OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            var orderDetails = context.GetInput<OrderDetails>();

            // Order Placed Notification
            await context.CallActivityAsync("SendOrderPlacedNotification", orderDetails);

            // Order Processed Notification
            await context.CallActivityAsync("SendOrderProcessedNotification", orderDetails);

            // Order Shipped Notification
            await context.CallActivityAsync("SendOrderShippedNotification", orderDetails);
        }
    }
}
