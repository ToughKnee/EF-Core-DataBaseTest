using CleanArchitectureWorkshop.Domain.Core;

namespace CleanArchitectureWorkshop.Domain.TeamAggregate;

public class TeamName : ValueObject
{
    public string Value { get; }

    private TeamName(string value)
    {
        Value = value;
    }

    public static TeamName Create(string teamName)
    {
        if (string.IsNullOrWhiteSpace(teamName))
        {
            throw new ArgumentException("Team name cannot be empty or whitespace.", nameof(teamName));
        }

        if (teamName.Contains('@'))
        {
            throw new ArgumentException("Team name cannot contain @.");
        }

        return new TeamName(teamName);
    }

    public override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }
}
