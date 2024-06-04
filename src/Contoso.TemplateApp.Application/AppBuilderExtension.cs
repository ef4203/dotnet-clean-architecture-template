// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Application;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public static class AppBuilderExtension
{
    public static void AddApplicationServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        builder.Services.AddMediatR(
            x =>
            {
                x.RegisterServicesFromAssembly(typeof(AppBuilderExtension).Assembly);
            });
    }
}
