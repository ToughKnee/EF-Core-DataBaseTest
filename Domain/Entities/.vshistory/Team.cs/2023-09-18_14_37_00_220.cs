using System.Collections.Generic;

namespace CleanArchitectureWorkshop.Domain.Entities;
public class Team
{
    private readonly List<Player> _players = new();
    public IReadOnlyCollection Players => _players.AsReadOnly();
    public TeamName TeamName { get; }

    public void AddPLayer(Player player)
    {
        Players.Add(player);
    }
    public void RemovePLayer(Player player)
    {
        if (Players.Contains(player))
        {
            Players.Remove(player);
        }
    }
}
