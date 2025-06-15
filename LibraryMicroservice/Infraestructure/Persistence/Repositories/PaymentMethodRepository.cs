using Domain.Entities.PaymentMethod;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {

        private readonly ApplicationDbContext _context;

        public PaymentMethodRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(PaymentMethod paymentMethod)
        {
            await _context.PaymentMethods.AddAsync(paymentMethod);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PaymentMethod>> GetAll() => await _context.PaymentMethods.ToListAsync();

        public async Task<PaymentMethod> GetByDescription(string description) => await _context.PaymentMethods.SingleOrDefaultAsync(paymentMethod => paymentMethod.Name == description);
    }
}
