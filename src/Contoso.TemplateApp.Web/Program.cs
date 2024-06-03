// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Web;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
