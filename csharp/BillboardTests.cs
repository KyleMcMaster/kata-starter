using System;
using AutoFixture.Idioms;
using FluentAssertions;
using Kata.Starter.Fixtures;
using Xunit;

namespace Kata.Starter;

public class BillboardTests
{
  [Theory, AutoDomainData]
  public void Constructor_Returns_Non_Null_Instance(string message)
  {
    var sut = new Billboard(message);

    sut.Should().NotBeNull();
  }

  [Theory, AutoDomainData]
  public void Constructor_Assigns_Fields_Using_Supplied_Value(string message)
  {
    var sut = new Billboard(message);

    sut.Message.Should().Be(message);
  }

  [Fact]
  public void Constructor_Inefficiently_Guards_Against_Null_Parameters()
  {
    var nullMessageAction = () => new Billboard(message: null);

    nullMessageAction.Should().Throw<ArgumentNullException>();
  }

  [Fact]
  public void Constructor_Guards_Against_Null_Parameters()
  {
    var fixture = new DomainFixture();
    var assertion = new GuardClauseAssertion(fixture);
    assertion.Verify(typeof(Billboard).GetConstructors());
  }
}
