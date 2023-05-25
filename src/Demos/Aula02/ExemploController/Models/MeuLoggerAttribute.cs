using Microsoft.AspNetCore.Mvc.Filters;

namespace ExemploController.Models
{
    public class MeuLoggerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Chamei o método {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"Terminei o método {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }
    }
}
