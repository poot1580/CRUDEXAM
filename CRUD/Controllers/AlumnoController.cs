using CRUD.domain.Facade;
using CRUD.entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            var lt =  FacadeAlumno.GetAll();

            ViewBag.list = lt;
            
            return View();
        }

        public ActionResult CreateAlum()  
        {
            return View();

        }

        public ActionResult ReadAlum()
        {

       
            return View();
        }
        public ActionResult UpdateAlum(int id)
        {
           
            ViewBag.alumno = FacadeAlumno.GetByID(id);
           
          
            return View();
        }
        [HttpPost]
        public ActionResult UpdateAlum(EntityAlumno alumno)
        {
            FacadeAlumno.Update(alumno);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult CreateAlum(EntityAlumno alumno)
        {
            var lt = FacadeAlumno.insertalumno(alumno);



            return View();
        }

        public ActionResult DeleteAlum(int Id)
        {
            FacadeAlumno.DeleteAlum(Id);




            return RedirectToAction("Index");
        }

    }
}