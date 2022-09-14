using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class HelloController : Controller
    {
        private static List<DogViewModel> dog=new List<DogViewModel>();
        private List<UserModel> GetUsers()
        {
            var usersList = new List<UserModel>
            {
                new UserModel
                {
                    UserId = 1,
                    UserName = "Ram",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 2,
                    UserName = "chand",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 3,
                    UserName = "Abc",
                    Company = "Abc Solutions"
                }
            };

            return usersList;
        }

        public JsonResult GetUsersData()
        {
            var users = GetUsers();
            return Json(users);
        }



        public IActionResult Index()
        {
            return View(dog);
        }

        public IActionResult Create()
        {

            var model = new DogViewModel();
            return View(model);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dog.Add(dogViewModel);
            return RedirectToAction("Index");
        }
    }
}
