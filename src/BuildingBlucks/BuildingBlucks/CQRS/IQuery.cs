using MediatR;


namespace BuildingBlucks.CQRS;

public interface IQuery<out TResponse> : IRequest<TResponse> 
    where TResponse : notnull
{
}
