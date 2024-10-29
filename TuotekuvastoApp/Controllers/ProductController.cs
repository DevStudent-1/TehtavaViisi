using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TuotekuvastoApp.Models;

namespace TuotekuvastoApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            var products = GetProducts();
            return View(products);
        }

        private List<Product> GetProducts()
        {
            var json = System.IO.File.ReadAllText("wwwroot/products.json");

            // Muutos alkuperäiseen. En asentanut erillistä NuGettia vaan käytän .NET olemassa olevaa System.Text.Json nimiavaruudesta löytyvää serializeria.

            var options = new JsonSerializerOptions() 
            { 
                PropertyNameCaseInsensitive = true            
            };

            return JsonSerializer.Deserialize<List<Product>>(json, options);
        }
    }
}
