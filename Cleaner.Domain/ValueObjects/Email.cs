namespace Cleaner.Domain.ValueObjects
{
    public readonly struct Email
    {
        public Email(string address) => Address = address;
        public string Address { get; }
    }
}