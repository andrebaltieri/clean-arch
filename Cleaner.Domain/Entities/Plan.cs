namespace Cleaner.Domain.Entities
{
    public class Plan : Entity
    {
        public Plan(string title, decimal amount)
        {
            Title = title;
            Amount = amount;
        }

        public string Title { get;  }
        public decimal Amount { get; }
    }
}