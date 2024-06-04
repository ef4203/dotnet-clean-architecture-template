// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Application.Helper;

using Contoso.TemplateApp.Domain.Generic;
using MediatR;
using Microsoft.VisualStudio.Threading;

public static class SubscribeExtension
{
    public static void Subscribe(this DomainObject domainObject, IPublisher publisher)
    {
        ArgumentNullException.ThrowIfNull(domainObject);
        ArgumentNullException.ThrowIfNull(publisher);

        domainObject.Events += (_, args) =>
        {
            using var taskContext = new JoinableTaskContext();
            new JoinableTaskFactory(taskContext)
                .Run(
                    async () =>
                    {
                        await publisher.Publish(args);
                    });
        };
    }
}
