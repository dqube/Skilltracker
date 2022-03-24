using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Microsoft.eShopOnContainers.Services.Ordering.API.Application.Behaviors;

public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        throw new NotImplementedException();
    }
}