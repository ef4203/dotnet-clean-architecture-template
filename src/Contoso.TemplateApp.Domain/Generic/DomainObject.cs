// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Domain.Generic;

public abstract class DomainObject
{
    public event EventHandler<DomainEventArgs>? Events;

    protected void RaiseEvent(DomainEventArgs @event)
    {
        this.Events?.Invoke(this, @event);
    }
}
