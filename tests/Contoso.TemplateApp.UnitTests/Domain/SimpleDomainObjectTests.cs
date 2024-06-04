// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.UnitTests.Domain;

using Contoso.TemplateApp.Domain;

public class SimpleDomainObjectTests
{
    [Test]
    public void SimpleDomainObject_SomethingHappened_MustRaiseEvent()
    {
        // Arrange
        var domainObject = new SimpleDomainObject();
        var eventRaised = false;
        domainObject.Events += (_, _) => eventRaised = true;

        // Act
        domainObject.SomethingHappened();

        // Assert
        eventRaised
            .Should()
            .BeTrue();
    }
}
