using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ordersSystem.DomainModels;

public class OrderItem : IBaseEntity
{
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// ID заказа к которому относится часть заказа
    /// </summary>
    public int OrderId { get; set; }
    
    /// <summary>
    /// Заказ
    /// </summary>
    public Order Order { get; set; }
    
    /// <summary>
    /// Имя предмета заказа
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Количество в заказе
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal Quantity { get; set; }
    
    /// <summary>
    /// Единица (Измерения?)
    /// </summary>
    public string Unit { get; set; }
}