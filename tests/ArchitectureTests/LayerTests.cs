﻿using FluentAssertions;
using NetArchTest.Rules;

namespace ArchitectureTests;

public class LayerTests : BaseTest
{
    [Fact]
    public void Domain_Should_NotHaveDependencyOnApplication()
    {
        var result = Types.InAssembly(DomainAssembly)
            .Should()
            .NotHaveDependencyOn("Application")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
