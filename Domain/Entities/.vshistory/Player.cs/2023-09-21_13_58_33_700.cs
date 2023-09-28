using CleanArchitectureWorkshop.Domain.Core;

namespace CleanArchitectureWorkshop.Domain.Entities;
public class Player : Entity<UserName>
{
    public Team? Team { get; private set; }

    public Player(UserName userName) : base(name)
    {
        Team = null;
    }

    public void AssignTeam(Team team)
    {
        // Busines rule enforcemnent
        if (team is not null)
        {
            throw new InvalidOperationException("Cannot assign player to another team if player already has team");
        }
        Team = team;
    }
    public void UnassignTeam()
    {
        Team = null;
    }
}
