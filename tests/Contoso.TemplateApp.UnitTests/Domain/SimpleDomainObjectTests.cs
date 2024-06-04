// Copyright (c) Elias Frank. All rights reserved.

namespace Contoso.TemplateApp.UnitTests.Domain;

using Contoso.TemplateApp.Domain;
using Contoso.TemplateApp.Domain.Generic;

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

    [Test]
    public void SimpleDomainObject_SomethingHappened_MustNotThrowWithNoEventSubscribers()
    {
        // Arrange
        var domainObject = new SimpleDomainObject();

        // Act
        var action = domainObject.SomethingHappened;

        // Assert
        action
            .Should()
            .NotThrow();
    }

    [Test]
    public void SimpleDomainObject_SomethingHappened_MustSendEventToMultipleEventSubscribers()
    {
        // Arrange
        var domainObject = new SimpleDomainObject();
        var eventCounter = 0;
        domainObject.Events += (_, _) => eventCounter++;
        domainObject.Events += (_, _) => eventCounter++;

        // Act
        domainObject.SomethingHappened();

        // Assert
        eventCounter
            .Should()
            .Be(2);
    }

    [Test]
    public void SimpleDomainObject_SomethingHappened_MustNotHaveEventOnUnsubscribed()
    {
        // Arrange
        var domainObject = new SimpleDomainObject();
        var eventRaised = false;
        var handler = new EventHandler<DomainEventArgs>((_, _) => eventRaised = true);
        domainObject.Events += handler;

        // Act
        domainObject.Events -= handler;
        domainObject.SomethingHappened();

        // Assert
        eventRaised
            .Should()
            .BeFalse();
    }

    [Test]
    public void SimpleDomainObject_SomethingHappened_MustNotThrowOnNullEventSubscriber()
    {
        // Arrange
        var domainObject = new SimpleDomainObject();
        domainObject.Events += null!;

        // Act
        var action = domainObject.SomethingHappened;

        // Assert
        action
            .Should()
            .NotThrow();
    }
}
