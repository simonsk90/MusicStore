using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;
using MusicStore.Models.Repositories;

namespace MusicStore.Controllers
{
    public class ArtistsController : Controller
    {
        private ArtistRepository repository = new ArtistRepository();

        // GET: Artists
        public ActionResult Index()
        {
            return View(repository.getAll());
        }

        // GET: Artists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = repository.get(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(repository.get(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            repository.add(artist);
            repository.saveChanges();
            return RedirectToAction("Index");

        }

    }
}
