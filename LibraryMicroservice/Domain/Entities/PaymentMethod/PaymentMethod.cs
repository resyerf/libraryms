using Domain.Primitives;

namespace Domain.Entities.PaymentMethod
{
    public sealed class PaymentMethod : AggregateRoot
    {
        private PaymentMethod()
        {

        }

        public PaymentMethod(PaymentMethodId id, string name)
        {
            Id = id;
            Name = name;
        }

        public PaymentMethodId Id { get; set; }

        public string Name { get; set; } = string.Empty;

    }
}
