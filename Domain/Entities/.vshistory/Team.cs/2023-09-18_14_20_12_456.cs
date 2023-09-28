namespace CleanArchitectureWorkshop.Domain.Entities;
public class Team
{
    public List<Player> Players;
    public TeamName TeamName;

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
