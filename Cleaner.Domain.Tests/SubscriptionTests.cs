using Cleaner.Domain.Entities;
using Cleaner.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cleaner.Domain.Tests
{
    [TestClass]
    [TestCategory("Subscription")]
    public class SubscriptionTests
    {
        [TestMethod("Should fail when payment not provided")]
        public void ShouldFailWhenPaymentNotProvided()
        {
            var name = new Name("André", "Baltieri");
            var email = new Email("andre@balta.io");
            var document = new Document("12345678901");
            var student = new Student(name, email, document);
            var subscription = new Subscription(null, student);

            Assert.AreEqual(false, subscription.IsValid);
            Assert.AreEqual(1, subscription.Notifications.Count);
        }

        [TestMethod("Should fail when student not provided")]
        public void ShouldFailWhenStudentNotProvided()
        {
            var payment = new Payment(779.90M, 779.90M);
            var subscription = new Subscription(payment, null);

            Assert.AreEqual(false, subscription.IsValid);
            Assert.AreEqual(1, subscription.Notifications.Count);
        }
    }
}