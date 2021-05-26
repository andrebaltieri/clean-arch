using System;

namespace Cleaner.Application.UseCases.Subscribe
{
    public class Output
    {
        public Output(Guid subscriptionId, int status = 200, string message = "")
        {
            SubscriptionId = subscriptionId;
            Status = status;
            Message = message;
        }
        
        public Guid SubscriptionId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}