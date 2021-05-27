namespace Cleaner.Domain.ValueObjects
{
    public readonly struct Document 
    {
        public Document(string number) => Number = number;
        public string Number { get; }
    }
}