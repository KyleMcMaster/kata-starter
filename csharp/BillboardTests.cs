using System;
using AutoFixture.Idioms;
using Shouldly;
using Kata.Starter.Fixtures;
using Xunit;

namespace Kata.Starter;

public class BillboardTests
{
  [Theory, AutoDomainData]
  public void Constructor_Returns_Non_Null_Instance(string message)
  {
    var sut = new Billboard(message);

    sut.ShouldNotBeNull();
  }

  [Theory, AutoDomainData]
  public void Constructor_Assigns_Fields_Using_Supplied_Value(string message)
  {
    var sut = new Billboard(message);

    sut.Message.ShouldBe(message);
  }

  [Fact]
  public void Constructor_Inefficiently_Guards_Against_Null_Parameters()
  {
    var nullMessageAction = () => new Billboard(message: null);

    nullMessageAction.ShouldThrow<ArgumentNullException>();
  }

  [Fact]
  public void Constructor_Guards_Against_Null_Parameters()
  {
    var fixture = new DomainFixture();
    var assertion = new GuardClauseAssertion(fixture);
    assertion.Verify(typeof(Billboard).GetConstructors());
  }
}
