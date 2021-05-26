using Cleaner.Domain.Specs;

namespace Cleaner.Domain.Entities
{
    public class Subscription : Entity, IAgregateRoot
    {
        public Subscription(Payment payment, Student student, Plan plan)
        {
            Payment = payment;
            Student = student;
            Plan = plan;
        }

        public Payment Payment { get; }
        public Student Student { get; }
        public Plan Plan { get; }

        public void Subscribe() => AddNotifications(this.EnsureCanSubscribe());
    }
}