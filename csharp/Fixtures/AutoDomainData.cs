using AutoFixture.Xunit2;

namespace Kata.Starter.Fixtures;

/// <summary>
/// Sourced from https://tech.trailmax.info/2014/01/convert-your-projects-from-nunitmoq-to-xunit-with-nsubstitute/
/// </summary>
public class AutoDomainDataAttribute : AutoDataAttribute
{
  public AutoDomainDataAttribute()
      : base(() => new DomainFixture())
  {
  }
}
