using Domain.Entities.PaymentMethod;

namespace Domain.Interfaces.Repositories
{
    public interface IPaymentMethodRepository
    {
        Task<PaymentMethod> GetByDescription(string description);
        Task Add(PaymentMethod paymentMethod);
        Task<List<PaymentMethod>> GetAll();
    }
}
