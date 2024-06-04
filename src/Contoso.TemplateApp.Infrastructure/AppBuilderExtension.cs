// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Infrastructure;

using Contoso.TemplateApp.Application.Abstraction;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public static class AppBuilderExtension
{
    public static void AddInfrastructureService(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        builder.Services.AddTransient<ISimpleInfrastructureService, SimpleInfrastructureService>();
    }
}
