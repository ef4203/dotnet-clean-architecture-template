// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Application.Events;

using Contoso.TemplateApp.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

public sealed partial class SimpleEventArgsHandler(ILogger<SimpleEventArgsHandler> logger)
    : INotificationHandler<SimpleEventArgs>
{
    private readonly ILogger<SimpleEventArgsHandler> logger = logger
        ?? throw new ArgumentNullException(nameof(logger));

    public Task Handle(SimpleEventArgs notification, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(notification);

        this.LogSimpleEvent(notification.Message);

        return Task.CompletedTask;
    }

    [LoggerMessage(LogLevel.Information, "Simple event - {Message}")]
    private partial void LogSimpleEvent(string message);
}
