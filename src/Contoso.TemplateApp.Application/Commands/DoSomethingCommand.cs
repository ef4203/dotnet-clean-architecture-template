// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Application.Commands;

using Contoso.TemplateApp.Application.Helper;
using Contoso.TemplateApp.Domain;
using MediatR;

public sealed record DoSomethingCommand : IRequest;

public class DoSomethingCommandHandler(IPublisher publisher) : IRequestHandler<DoSomethingCommand>
{
    public Task Handle(DoSomethingCommand request, CancellationToken cancellationToken)
    {
        var simple = new SimpleDomainObject();
        simple.Subscribe(publisher);
        simple.SomethingHappened();

        return Task.CompletedTask;
    }
}
