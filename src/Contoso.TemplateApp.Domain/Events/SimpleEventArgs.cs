// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Domain.Events;

using Contoso.TemplateApp.Domain.Generic;

public class SimpleEventArgs(string message) : DomainEventArgs
{
    public string Message { get; } = message;
}
