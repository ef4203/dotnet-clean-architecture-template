// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Application.Helper;

using Contoso.TemplateApp.Domain.Generic;
using MediatR;

public static class SubscribeExtension
{
    public static void Subscribe(this DomainObject domainObject, IPublisher publisher)
    {
        ArgumentNullException.ThrowIfNull(domainObject);
        ArgumentNullException.ThrowIfNull(publisher);

        domainObject.Events += (_, args) =>
        {
#pragma warning disable S4462
#pragma warning disable VSTHRD002
            publisher.Publish(args)
                .GetAwaiter()
                .GetResult();
#pragma warning restore VSTHRD002
#pragma warning restore S4462
        };
    }
}
