using Cleaner.Domain.ValueObjects;

namespace Cleaner.Domain.Entities
{
    public class Student : Entity
    {
        public Student(Name name, Email email, Document document)
        {
            Name = name;
            Email = email;
            Document = document;
        }

        public Name Name { get; }
        public Email Email { get; }
        public Document Document { get; }
    }
}