using MediatR;

namespace Application.Command.PaymentMethod
{
    public record class CreatePaymentMethodCommand(
        string Name
        ) : IRequest<Unit>;
}
