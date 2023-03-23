namespace ordersSystem.DomainModels.Dto;

public class MakeOrder
{
    /// <summary>
    /// Номер телефона для контактов
    /// </summary>
    public string Number { get; set; }
    
    /// <summary>
    /// "Корзина"
    /// </summary>
    public ICollection<OrderItem> OrderItems { get; set; }
    
    /// <summary>
    /// Выбранный исполнитель
    /// </summary>
    public int ProviderId { get; set; }
}