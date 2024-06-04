// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.UnitTests.Commands;

using Contoso.TemplateApp.Application.Abstraction;
using Contoso.TemplateApp.Application.Commands;
using MediatR;
using Moq;

public class DoSomethingCommandTests
{
    [Test]
    public async Task DoSomethingCommand_Handle_MustCallService()
    {
        // Arrange
        var service = new Mock<ISimpleInfrastructureService>();

        // Act
        await new DoSomethingCommandHandler(Mock.Of<IPublisher>(), service.Object)
            .Handle(default, CancellationToken.None);

        // Assert
        service.Verify(
            x => x.DoSomethingExternalAsync(),
            Times.Once);
    }

    [Test]
    public void DoSomethingCommandHandler_Constructor_ThrowsArgumentNullException()
    {
        // Act
        var func = () => _ = new DoSomethingCommandHandler(null!, Mock.Of<ISimpleInfrastructureService>());

        // Assert
        func.Should()
            .Throw<ArgumentNullException>()
            .And
            .ParamName
            .Should()
            .Be("publisher");

        // Act
        func = () => _ = new DoSomethingCommandHandler(Mock.Of<IPublisher>(), null!);

        // Assert
        func.Should()
            .Throw<ArgumentNullException>()
            .And
            .ParamName
            .Should()
            .Be("service");
    }
}
