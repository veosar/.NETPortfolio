﻿using AN.Domain.Entities.Orders;
using MediatR;
using Rebus.Bus;

namespace AN.Application.Orders.Create;

internal sealed class OrderCreatedDomainEventHandler : INotificationHandler<OrderCreatedDomainEvent>
{
    private readonly IBus _bus;

    public OrderCreatedDomainEventHandler(IBus bus)
    {
        _bus = bus;
    }

    public async Task Handle(OrderCreatedDomainEvent notification, CancellationToken cancellationToken)
    {
        // await _bus.Send(new OrderCreatedIntegrationEvent(notification.OrderId.Value));
    }
}