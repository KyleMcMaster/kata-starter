using AutoFixture;
using AutoFixture.AutoNSubstitute;

namespace Kata.Starter.Fixtures;

public class DomainFixture : Fixture
{
  public DomainFixture() : base() =>
      Customize(new AutoNSubstituteCustomization());
}
