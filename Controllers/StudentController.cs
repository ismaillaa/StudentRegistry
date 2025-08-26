using Microsoft.AspNetCore.Mvc;
using StudentRegistry.Data;
using StudentRegistry.Models;

namespace StudentRegistry.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db) {
            _db = db;
        }

        public IActionResult Index(string searchString)
        {
            var students = from s in _db.RegistryStudent
                           select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.name.Contains(searchString) || s.email.Contains(searchString));
            }

            return View(students.ToList());
        }



        //GET
        public IActionResult Create()
        {
                    
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.RegistryStudent.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Student created successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var StudentFromDb = _db.RegistryStudent.Find(id);
            if (StudentFromDb == null)
            {
                return NotFound();
            }

            return View(StudentFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.RegistryStudent.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Student updated successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var StudentFromDb = _db.RegistryStudent.Find(id);
            if (StudentFromDb == null)
            {
                return NotFound();
            }

            return View(StudentFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            
            
                var obj = _db.RegistryStudent.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }


                _db.RegistryStudent.Remove(obj);
                _db.SaveChanges();
                TempData["success"] = "Student removed successfully";
                return RedirectToAction("Index");
            
        }

    }
}
