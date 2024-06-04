// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Web;

using Contoso.TemplateApp.Application;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.AddApplicationServices();

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
