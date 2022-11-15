using System;
using Microsoft.AspNetCore.Mvc;
using ClientsCRUD.Data;
using ClientsCRUD.Models;

namespace ClientsCRUD.Controllers
{
	public class ClientsController : Controller
	{
		private readonly ApplicationDbContext _dbContext;

		public ClientsController(ApplicationDbContext  context)
		{
			_dbContext = context;
		}

		public IActionResult Index()
		{
			List<Clients> clients = _dbContext.clients.ToList();
			return View(clients);
		}
	}
}

