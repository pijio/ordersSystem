using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ordersSystem.Api.Services;
using ordersSystem.DomainModels.Dto;

namespace ordersSystem.Api.Controllers;

[ApiController]
[EnableCors("CommonPolicy")]
[Microsoft.AspNetCore.Components.Route("/api")]
public class OrdersController : Controller
{
    private readonly OrderService _orderService;

    public OrdersController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("makeorder")]
    public async Task<IActionResult> MakeOrder(MakeOrder orderInfo)
    {
        return Ok();
    }
}