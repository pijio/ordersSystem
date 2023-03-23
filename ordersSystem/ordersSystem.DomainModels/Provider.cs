namespace ordersSystem.DomainModels;

public class Provider : IBaseEntity
{
    public int Id { get; set; }
    
    public string Name { get; set; }
}