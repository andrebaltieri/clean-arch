using System;

namespace Cleaner.Domain.Entities
{
    public class Payment : Entity
    {
        public Payment(decimal amount, decimal paidAmount)
        {
            CreateDate = DateTime.Now;
            PaidDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            Amount = amount;
            PaidAmount = paidAmount;
        }

        public DateTime CreateDate { get; }
        public DateTime PaidDate { get; }
        public DateTime LastUpdateDate { get; }
        public decimal Amount { get; }
        public decimal PaidAmount { get; }
    }
}