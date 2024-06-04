// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Application.Events;

using Contoso.TemplateApp.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

public class SimpleEventArgsHandler(ILogger<SimpleEventArgsHandler> logger) : INotificationHandler<SimpleEventArgs>
{
    public Task Handle(SimpleEventArgs notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Simple event - {Message}", notification.Message);

        return Task.CompletedTask;
    }
}
