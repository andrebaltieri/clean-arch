using System;
using Cleaner.Application.Models;

namespace Cleaner.Application.UseCases.Subscribe
{
    public class Input
    {
        // TODO: Validar
        public Guid StudentId { get; set; }
        public Guid PlanId { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}