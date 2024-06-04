// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Web;

using Contoso.TemplateApp.Application;
using Contoso.TemplateApp.Infrastructure;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.AddApplicationServices();
        builder.AddInfrastructureService();

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
