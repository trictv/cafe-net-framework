using Cafe.Dados;
using Cafe.Models;
using Glimpse.Ado.Tab;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Controllers
{
    public class NovidadesController : Controller
    {
        private Context _context;
        //
        public NovidadesController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            ModelState.Clear();


            Contato NewContato = new Contato();
            return View("Index", NewContato);
        }
    }
}
