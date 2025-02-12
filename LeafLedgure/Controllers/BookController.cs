using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeafLedgure.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
