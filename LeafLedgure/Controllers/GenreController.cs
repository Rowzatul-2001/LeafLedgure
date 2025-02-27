using LeafLedgure.Models.Domain;
using LeafLedgure.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LeafLedgure.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService service;
        public GenreController(IGenreService service)
        {
            this.service = service;
        }
        public IActionResult Add()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Add(Genre model)
        {
            Console.WriteLine($"📌 Received Genre: {model.GenreName}");

            if (!ModelState.IsValid)
            {
                Console.WriteLine("❌ ModelState is INVALID! Errors:");
                foreach (var error in ModelState)
                {
                    foreach (var subError in error.Value.Errors)
                    {
                        Console.WriteLine($"⛔ Field: {error.Key} | Error: {subError.ErrorMessage}");
                    }
                }

                TempData["msg"] = "Validation failed. Please check your input.";
                return View(model);
            }

            var result = service.Add(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully!";
                return RedirectToAction(nameof(Add));
            }

            TempData["msg"] = "Error occurred";
            return View(model);
        }




        public IActionResult Update(int id)
        {
            var record = service.FindById(id);
            return View(record);
        }

        [HttpPost]
        public IActionResult Update(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Update(model);
            if (result)
            {
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error occurred";
            return View(model);
        }


        public IActionResult Delete(int id)
        {

            var result = service.Delete(id);
            return RedirectToAction("GetAll");
        }

        public IActionResult GetAll()
        {

            var data = service.GetAll();
            return View(data);
        }
    }
}
