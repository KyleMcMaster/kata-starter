using System.Collections.Generic;
using Ardalis.GuardClauses;

namespace Kata.Starter;

public class Painter
{
  private string FirstName { get; }
  private string LastName { get; }
  private string SocialSecurityNumber { get; }

  private List<Billboard> Tasks { get; }

  public Painter(string firstName, string lastName, string socialSecurityNumber)
  {
    Guard.Against.NullOrWhiteSpace(firstName, nameof(firstName));
    Guard.Against.NullOrWhiteSpace(lastName, nameof(lastName));
    Guard.Against.NullOrWhiteSpace(socialSecurityNumber, nameof(socialSecurityNumber));

    FirstName = firstName;
    LastName = lastName;
    SocialSecurityNumber = socialSecurityNumber;

    Tasks = [];
  }

  public void AddBillboardToPaint(Billboard billboard)
  {
    Guard.Against.Null(billboard, nameof(billboard));

    Tasks.Add(billboard);
  }
}
