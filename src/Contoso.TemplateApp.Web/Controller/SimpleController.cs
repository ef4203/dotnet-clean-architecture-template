// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.Web.Controller;

using Contoso.TemplateApp.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("simple")]
public class SimpleController(ISender sender) : ControllerBase
{
    [HttpGet]
    public async Task IndexAsync()
    {
        await sender.Send(new DoSomethingCommand());
    }
}
