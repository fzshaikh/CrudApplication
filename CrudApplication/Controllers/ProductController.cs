using CrudApplication.EF;
using CrudApplication.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CrudApplication.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext _context;
        public ProductController()
        {
                _context = new ProductDbContext();
        }
        public ActionResult Index()
        {

            return View(_context.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
           var productObject = _context.Products.Find(id);
            return View(productObject); 
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            _context.Entry(product).State = EntityState.Modified; 
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var productObject = _context.Products.Find(id);
            return View(productObject);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            var productObject = _context.Products.Find(id);
            _context.Products.Remove(productObject);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
            public ActionResult Details(int id) 
        {
            var productObject = _context.Products.Find(id);

            return View(productObject);  
        }
    }
}