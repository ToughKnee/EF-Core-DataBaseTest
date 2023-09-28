using CleanArchitectureWorkshop.Domain.Core;
using System.Collections.Generic;

namespace CleanArchitectureWorkshop.Domain.Entities;
// The  "Team" must inherit from "Aggregate Root" insted of Entity, because it has a collection of other entities
public class Team : AggregateRoot<TeamName>
{
    private readonly List<Player> _players = new();
    public IReadOnlyCollection<Player> Players => _players.AsReadOnly();

    public Team(TeamName name) : base(name)
    {
    }
    public void AddPLayer(Player player)
    {
        // TODO: Fix when value object add entity equality is implemented
        // Now when we implement the inheritance, 
        if(_players.Exists(p => p == player))
        {
            throw new InvalidOperationException("Player is already on the team");
        }
        _players.Add(player);
        player.AssignTeam(this);
    }

    // To better manage the removing responsibilities from player and team, we use aggregate root, this means that we treat both the same when we add or remove, meaning that we will call both methods that control the assignments between them, like it was done in the method "AddPlayer", which has the "hard logic" to add the player, but it uses the "refined logic" from player to keep consistency
    public void RemovePLayer(Player player)
    {
        // "Contains" method from List is preferred for simple types, because it will compare the passed value as a reference
        // if (Players.Contains(player))
        // {
        //     Players.Remove(player);
        // }
        if(!_players.Exists(p => p.UserName == player.UserName))
        {
            throw new InvalidOperationException("Player is not in the team");
        }
        _players.Remove(player);
        player.UnassignTeam();

    }
}
