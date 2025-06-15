using Domain.Entities.PaymentMethod;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Command.PaymentMethod
{
    internal sealed class CreatePaymentMethodCommandHandler : IRequestHandler<CreatePaymentMethodCommand, Unit>
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;

        public CreatePaymentMethodCommandHandler(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
        }

        public async Task<Unit> Handle(CreatePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            
            var paymentMethod = new Domain.Entities.PaymentMethod.PaymentMethod(
                                    new PaymentMethodId(Guid.NewGuid()),
                                    request.Name);

            await _paymentMethodRepository.Add(paymentMethod);

            return Unit.Value;
        }
    }
}