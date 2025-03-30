using Microsoft.AspNetCore.Mvc;
using Store_CRUD_MVC.Services;

namespace Store_CRUD_MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p=> p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {


            return View();
        }
    }
}
