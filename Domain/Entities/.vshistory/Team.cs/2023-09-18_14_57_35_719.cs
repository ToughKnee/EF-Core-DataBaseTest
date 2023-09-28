﻿using System.Collections.Generic;

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
        player.AssignTeam(this);
    }

    // To better manage the removing responsibilities from player and team, we use aggregate root, this means that we treat both the same when we add or remove, meaning that we will call both methods that control the assignments between them, like it was done in the method "AddPlayer", which has the "hard logic" to add the player, but it uses the "refined logic" from player to keep coherency
    public void RemovePLayer(Player player)
    {
        // Contains is preferred for simple types, because it will compare the passed value as a reference
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