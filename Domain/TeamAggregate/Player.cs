using CleanArchitectureWorkshop.Domain.Core;

namespace CleanArchitectureWorkshop.Domain.TeamAggregate;

public class Player : Entity<UserName>
{
    public Team? Team { get; private set; }


    public Player(UserName userName)
        : base(userName)
    {
    }

    // For EFCore, do not use.
    private Player()
    {
    }

    public void AssignTeam(Team team)
    {
        // Business rule / invariant enforcement.
        if (Team is not null)
        {
            throw new InvalidOperationException("Cannot assign team to a player that is already a member of a team.");
        }

        Team = team;
    }

    public void UnassignTeam()
    {
        Team = null;
    }
}
