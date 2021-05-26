using Cleaner.Domain.Specs;

namespace Cleaner.Domain.Entities
{
    public class Subscription : Entity, IAgregateRoot
    {
        public Subscription(Payment payment, Student student)
        {
            Payment = payment;
            Student = student;
        }

        public Payment Payment { get; }
        public Student Student { get; }

        public void Subscribe() => AddNotifications(this.EnsureCanSubscribe());
    }
}