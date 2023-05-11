namespace BlazingPizza.Controller;

using BlazingPizza.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("specials")]
[ApiController]
public class SpecialsController : ControllerBase
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db) => _db = db;

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        var valores = (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        return valores;
    }
}
