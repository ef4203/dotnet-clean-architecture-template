// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Domain.Generic;

public class DomainObject
{
    protected DomainObject()
    {
    }

    public event EventHandler<DomainEventArgs>? Events;

    protected void PublishEvent(DomainEventArgs @event)
    {
        this.Events?.Invoke(this, @event);
    }
}
