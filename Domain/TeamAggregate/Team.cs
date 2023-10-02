using CleanArchitectureWorkshop.Domain.Core;

namespace CleanArchitectureWorkshop.Domain.TeamAggregate;

public class Team : AggregateRoot<TeamName>
{
    public IReadOnlyCollection<Player> Players => _players.AsReadOnly();

    private readonly List<Player> _players = new();

    public Team(TeamName name)
        : base(name)
    {
    }

    // For EFCore, do not use.
    private Team()
    {
    }

    public void AddPlayer(Player player)
    {
        if (_players.Exists(p => p == player))
        {
            throw new InvalidOperationException("Player is already on the team.");
        }

        _players.Add(player);
        player.AssignTeam(this);
    }

    public void RemovePlayer(UserName playerId)
    {
        var playerToRemove = _players.FirstOrDefault(p => p.Id == playerId);
        if (playerToRemove is null)
        {
            throw new InvalidOperationException("Player is not on the team.");
      
        }

        _players.Remove(playerToRemove);
        playerToRemove.UnassignTeam();
    }

}
