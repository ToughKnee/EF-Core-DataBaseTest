namespace CleanArchitectureWorkshop.Domain.Entities;
public class UserName
{
    public string Value { get; }

    private UserName(string value)
    {
        Value = value;
    }
}
