using Microsoft.AspNetCore.Mvc;
using FirstMVCProject.Models;

namespace FirstMVCProject.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel) 
        {

            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello() 
        {
            return "Who's there?";
        }
    }
}
