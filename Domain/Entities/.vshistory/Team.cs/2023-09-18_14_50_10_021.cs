using System.Collections.Generic;

namespace CleanArchitectureWorkshop.Domain.Entities;
public class Team
{
    private readonly List<Player> _players = new();
    public IReadOnlyCollection<Player> Players => _players.AsReadOnly();
    public TeamName TeamName { get; }

    public Team(TeamName name)
    {
        TeamName = name;
    }
    public void AddPLayer(Player player)
    {
        // TODO: Fix when value object add entity equality is implemented
        if(_players.Exists(p => p.UserName == player.UserName))
        {
            throw new InvalidOperationException("Player is already on the team");
        }
        _players.Add(player);
    }
    public void RemovePLayer(Player player)
    {
        // Contains is preferred for simple types, because it will compare the passed value as a reference
        // if (Players.Contains(player))
        // {
        //     Players.Remove(player);
        // }
    }
}
