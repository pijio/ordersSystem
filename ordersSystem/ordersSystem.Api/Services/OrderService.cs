using ordersSystem.DataAccessLayer;

namespace ordersSystem.Api.Services;

public class OrderService
{
    private readonly IUnitOfWork _uow;

    public OrderService(IUnitOfWork uow)
    {
        _uow = uow;
    }
}