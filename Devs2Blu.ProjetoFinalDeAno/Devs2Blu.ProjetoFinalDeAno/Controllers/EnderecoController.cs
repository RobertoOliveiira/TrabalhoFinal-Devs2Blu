using Microsoft.AspNetCore.Mvc;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;
using Devs2Blu.ProjetoFinalDeAno.Models.DTO;

namespace Devs2Blu.ProjetoFinalDeAno.Controllers
{
    public class EnderecoController : Controller
    {

        private readonly IEnderecoService _service;
        public EnderecoController(IEnderecoService service)
        {
            _service = service;
        }
        // GET: Endereco/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var endereco = await _service.FindById(id);

                return Json(endereco);
            }
            catch
            {
                return NotFound();
            }
            
        }

        [HttpPost]
        public async Task<ActionResult<int>> CriarEnderecoComCliente(EnderecoViewModel endereco)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.Save(endereco.ToEntity());
                return new ActionResult<int>(id);
            }
            return View(endereco);
        }
        
        [HttpPost]
        public async Task<ActionResult<string>> Editend(EnderecoViewModel endereco)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.Update(endereco.ToEntity());
                    
                }
                catch
                {
                        return NotFound();
                    
                }
                return new ActionResult<string>("ok");
            }
            return View(endereco);
        }

        
        [HttpPost]
        public async Task<ActionResult<string>> DeleteEndereco(EnderecoViewModel endereco)
        {
            if (endereco != null)
            {
                await _service.Delete(endereco.ToEntity());
                return new ActionResult<string>("Cliente Excluído com sucesso!!!");
            }
            return NotFound();
            
        }

    }
}
