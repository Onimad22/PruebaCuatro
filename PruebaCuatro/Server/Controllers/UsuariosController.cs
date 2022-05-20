using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaCuatro.Server.Data;
using PruebaCuatro.Shared.DTOs;

namespace PruebaCuatro.Server.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public UsuariosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // GET: UsuariosController
        [HttpGet]
        public async Task<ActionResult<List<UsuarioDTO>>> Index()
        {
            return await context.Users.Select(x => 
            new UsuarioDTO { Email = x.Email, UserId = x.Id }).ToListAsync(); 
        }

      
    }
}
