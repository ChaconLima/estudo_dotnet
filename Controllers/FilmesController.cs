using System.Runtime.InteropServices;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Controller]
    [Route("/")]
    public class FilmesController: ControllerBase
    {

        private readonly DataContext _context;

        public FilmesController(DataContext context){
            this._context = context;
        }

        [HttpGet]
        public ActionResult Status(){
            return Ok("status - ok");
        }

        [HttpGet("Filmes")]
        public async Task <ActionResult> GetFilmes(){
    
            var filmes = await _context.Filmes.ToListAsync();
            return Ok(filmes);
    
        }


    }

}