using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;

namespace Devs2Blu.ProjetoFinalDeAno.Controllers
{
    public class NewslettersController : Controller
    {

        private readonly INewsletterService _service;
        public NewslettersController(INewsletterService service)
        {
            _service = service;
        }
        
        public  IActionResult Index()
        {
          return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewUser(Newsletter newsletter)
        {
            if (ModelState.IsValid)
            {
                await _service.Save(newsletter);
                //await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
