using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;
using Domain.Concrete;
using System.IO;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IMusicRepository repository;

        public HomeController(IMusicRepository repo)
        {
            repository = repo;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(repository.Musics);
        }

        public PartialViewResult Get(int id)
        {
            Music dbEntry = repository.Get(id);
            if (dbEntry == null)
                return PartialView();
            return PartialView(dbEntry);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Music mc, HttpPostedFileBase uploadMusic)
        {
            if (ModelState.IsValid && uploadMusic != null)
            {
                byte[] musicData = null;
                using (var binaryReader = new BinaryReader(uploadMusic.InputStream))
                {
                    musicData = binaryReader.ReadBytes(uploadMusic.ContentLength);
                }
                mc.File = musicData;
                repository.Save(mc);
                return RedirectToAction("Index");
            }
            return View(mc);
        }
    }
}