// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Domain;

using Contoso.TemplateApp.Domain.Events;
using Contoso.TemplateApp.Domain.Generic;

public class SimpleDomainObject : DomainObject
{
    public string Name { get; set; } = string.Empty;

    public void SomethingHappened()
    {
        this.PublishEvent(new SimpleEventArgs("Something happened!"));
    }
}
