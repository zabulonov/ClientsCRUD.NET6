using System;
using Microsoft.AspNetCore.Mvc;
using ClientsCRUD.Data;
using ClientsCRUD.Models;

namespace ClientsCRUD.Controllers
{
	public class ClientsController : Controller
	{
		private readonly ApplicationDbContext _db;

		public ClientsController(ApplicationDbContext  context)
		{
			_db = context;
		}

		// GET Controller
		public IActionResult Index()
		{
			List<Clients> clients = _db.clients.ToList();
			return View(clients);
		}

		// GET: Create
		public IActionResult Create()
		{
			return View();
		}

		// POST : Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Clients obj)
		{
			if(ModelState.IsValid)
			{
				_db.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
            return View(obj);
        }

        // GET: Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

		// POST : Delete
		[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost	(int? id)
		{
            var obj = _db.clients.Find(id);
            if (obj == null)
				return NotFound();

            _db.clients.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

		// GET : Edit

		public IActionResult Edit(int? id)
		{
			if ((id == null) || (id == 0))
				return NotFound();

			var obj = _db.clients.Find(id);

			if (obj == null)
				return NotFound();

			return View(obj);

		}
    }
}

