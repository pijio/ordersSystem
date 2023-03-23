using System.Runtime.CompilerServices;

namespace ordersSystem.DomainModels.Dto;

public class Order
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
    /// Исполнитель
    /// </summary>
    public Provider Provider { get; set; }
    
    /// <summary>
    /// "Корзина"
    /// </summary>
    public ICollection<OrderItem> OrderItems { get; set; }

    public static Order ByDomain(DomainModels.Order order)
    {
        var dto = new Order
        {
            Id = order.Id,
            Number = order.Number,
            Date = order.Date,
            Provider = order.Provider,
            OrderItems = order.OrderItems
        };
        return dto;
    }
}