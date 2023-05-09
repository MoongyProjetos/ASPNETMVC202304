using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDeploy.Model;

namespace WebAppDeploy.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration Configuration;
    private readonly BibliotecaDbContext _context;


    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration, BibliotecaDbContext context)
    {
        _logger = logger;
        Configuration = configuration;
        _context = context;
    }

    public void OnGet()
    {
        var novaPessoa = new Person { Age = 38, LastName = "Oliveira", FirstName = "Jonatas" };
        _context.People.Add(novaPessoa);
        _context.SaveChanges();

        var listaPessoas = _context.People.ToList();


        var valor = Boolean.Parse(Configuration["MinhaFeature"]);

        if(valor == true)
        {
            ViewData["Exemplo"] = "Feature Ativada";
        }
        else
        {
            ViewData["Exemplo"] = "Feature Desligada";
        }
    }
}
