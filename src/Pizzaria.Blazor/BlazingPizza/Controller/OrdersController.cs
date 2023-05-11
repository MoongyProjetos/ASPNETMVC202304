namespace BlazingPizza.Controller;

using BlazingPizza.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("orders")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly PizzaStoreContext db;

    public OrdersController(PizzaStoreContext db) => this.db = db;

    [HttpGet]
    public async Task<ActionResult<List<OrderWithStatus>>> GetOrders()
    {
        var orders = await db.Orders
         .Include(o => o.Pizzas).ThenInclude(p => p.Special)
         .Include(o => o.Pizzas).ThenInclude(p => p.Toppings).ThenInclude(t => t.Topping)
         .OrderByDescending(o => o.CreatedTime)
         .ToListAsync();

        return orders.Select(o => OrderWithStatus.FromOrder(o)).ToList();
    }

    [HttpPost]
    public async Task<ActionResult<int>> PlaceOrder(Order order)
    {
        order.CreatedTime = DateTime.Now;

        // Enforce existence of Pizza.SpecialId and Topping.ToppingId
        // in the database - prevent the submitter from making up
        // new specials and toppings
        foreach (var pizza in order.Pizzas)
        {
            pizza.SpecialId = pizza.Special.Id;
            pizza.Special = null;
        }

        _ = db.Orders.Attach(order);
        _ = await db.SaveChangesAsync();

        return order.OrderId;
    }
}
