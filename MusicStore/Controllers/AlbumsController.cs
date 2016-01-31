using MusicStore.Models;
using MusicStore.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MusicStore.Controllers
{
    public class AlbumsController : Controller
    {

        //private MusicStoreContext context = new MusicStoreContext();
        private AlbumRepository repository = new AlbumRepository();

        // GET: Album
        public ActionResult Index()
        {
            return View(repository.getAll());
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Album album)
        {
            repository.add(album);
            repository.saveChanges();

            return RedirectToAction("Index");
        }
    }
}