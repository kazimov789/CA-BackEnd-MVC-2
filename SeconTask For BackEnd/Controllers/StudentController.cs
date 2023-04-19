using Microsoft.AspNetCore.Mvc;
using SeconTask_For_BackEnd.DataAccess;
using SeconTask_For_BackEnd.Models;
using System.Collections.Generic;

namespace SeconTask_For_BackEnd.Controllers
{
    public class StudentController:Controller
    {
        public ViewResult Index()
        {
            List<Student> students = Data.Students;

            return View(students);
        }
        public ViewResult Detail(int id)
        {
            List<Student> students = Data.Students;
            Student student = students.Find(x => x.Id == id);

            return View(student);
        }
    }
}
