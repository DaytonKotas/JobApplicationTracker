using Microsoft.AspNetCore.Mvc;
using JobApplicationTracker.Models;
using JobApplicationTracker.Repositories;

namespace JobApplicationTracker.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ApplicationRepository _repository;

        public ApplicationController(ApplicationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var applications = _repository.GetAllApplications();
            return View(applications);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Application application)
        {
            if (ModelState.IsValid)
            {
                _repository.AddApplication(application);
                return RedirectToAction("Index");
            }
            return View(application);
        }

        // Implement Edit, Delete, and Details actions
    }
}
