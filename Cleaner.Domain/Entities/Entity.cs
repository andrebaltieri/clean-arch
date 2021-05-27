using System;
using Flunt.Notifications;

namespace Cleaner.Domain.Entities
{
    public abstract class Entity : Notifiable<Notification>, 
        IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public bool Equals(Entity other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Entity) obj);
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}