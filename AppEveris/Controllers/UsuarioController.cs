using AppEveris.Models;
using AppEveris.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEveris.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _usuarioService.Get();
        }

        [HttpPost]
        public Usuario Post([FromBody] Usuario usuario)
        {
            return _usuarioService.Add(usuario);
        }

        [HttpPut("{id}")]
        public Usuario Put([FromBody] Usuario usuario)
        {
            return _usuarioService.Update(usuario);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _usuarioService.Delete(id);
            return Ok();
        }

    }
}
