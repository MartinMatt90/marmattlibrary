using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccAcademyBookStore.Controllers
{
    public class GenreController : Controller
    {
        
        public ActionResult insertGenre(Genres newGenre)
        {
            if (newGenre == null)
            {
                return Content("No puedo insertar los datos falta el nombre del genero");
            }

            AccAcademyBookStoreEntities db = new AccAcademyBookStoreEntities();

            db.Genres.Add(newGenre);
            db.SaveChanges();

            return RedirectToAction("Insert");
        }





    }
}