namespace ordersSystem.DomainModels;

public class Order : IBaseEntity
{
    public int Id { get; set; }
    
    /// <summary>
    /// Номер телефона для контактов
    /// </summary>
    public string Number { get; set; }
    
    /// <summary>
    /// Время заказа
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// ID исполнитель
    /// </summary>
    public int ProviderId { get; set; }
    
    /// <summary>
    /// Исполнитель
    /// </summary>
    public Provider Provider { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
}