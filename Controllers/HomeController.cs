using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoListWithSacffolding.Models;
using ToDoListWithSacffolding.Repositories;


namespace ToDoListWithSacffolding.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var students = StudentRepository.GetAll();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentRepository.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = StudentRepository.GetById(id);
            if (student == null) return NotFound();

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentRepository.Update(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Details(int id)
        {
            var student = StudentRepository.GetById(id);
            if (student == null) return NotFound();

            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = StudentRepository.GetById(id);
            if (student == null) return NotFound();

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            StudentRepository.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
