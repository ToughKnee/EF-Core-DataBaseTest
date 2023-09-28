namespace CleanArchitectureWorkshop.Domain.Entities;
public class Player
{
    public Team? Team { get; }
    public UserName UserName{ get;}

    public Player(UserName userName)
    {
        UserName = userName;
        Team = null;
    }

    public void AssignTeam()
    {

    }
}
