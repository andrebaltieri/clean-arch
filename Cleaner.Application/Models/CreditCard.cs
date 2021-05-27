namespace Cleaner.Application.Models
{
    public class CreditCard
    {
        // TODO: Validar dados
        public string Holder { get; set; }
        public string Number { get; set; }
        public string Expiration { get; set; }
        public string Cvv { get; set; }
    }
}