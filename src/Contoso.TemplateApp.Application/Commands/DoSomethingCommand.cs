// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Application.Commands;

using Contoso.TemplateApp.Application.Abstraction;
using Contoso.TemplateApp.Application.Helper;
using Contoso.TemplateApp.Domain;
using MediatR;

public sealed record DoSomethingCommand : IRequest;

public class DoSomethingCommandHandler(
    IPublisher publisher,
    ISimpleInfrastructureService service)
    : IRequestHandler<DoSomethingCommand>
{
    private readonly IPublisher publisher = publisher
        ?? throw new ArgumentNullException(nameof(publisher));

    private readonly ISimpleInfrastructureService service = service
        ?? throw new ArgumentNullException(nameof(service));

    public async Task Handle(DoSomethingCommand request, CancellationToken cancellationToken)
    {
        var simple = new SimpleDomainObject();
        simple.Subscribe(this.publisher);
        simple.SomethingHappened();

        await this.service.DoSomethingExternalAsync();
    }
}
