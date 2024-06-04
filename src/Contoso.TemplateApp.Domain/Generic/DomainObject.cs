// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Domain.Generic;

public class DomainObject
{
    protected DomainObject()
    {
    }

    public event EventHandler<DomainEventArgs>? Events;

#pragma warning disable CA1030
    protected void RaiseEvent(DomainEventArgs @event)
#pragma warning restore CA1030
    {
        this.Events?.Invoke(this, @event);
    }
}
