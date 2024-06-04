// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Infrastructure;

using Contoso.TemplateApp.Application.Abstraction;

public class SimpleInfrastructureService : ISimpleInfrastructureService
{
    public Task DoSomethingExternalAsync()
    {
        return Task.CompletedTask;
    }
}
