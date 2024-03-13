using Ardalis.GuardClauses;

namespace Kata.Starter;

public class Billboard
{
  public string Message { get; }

  public Billboard(string message)
  {
    Guard.Against.NullOrWhiteSpace(message, nameof(message));

    this.Message = message;
  }

  public Billboard(Billboard original)
  {
    Guard.Against.Null(original, nameof(original));

    this.Message = original.Message;
  }
}
