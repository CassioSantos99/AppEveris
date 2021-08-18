using AppEveris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEveris.Services
{
    public interface IUsuarioService
    {
        List<Usuario> Get();
        Usuario Add(Usuario usuario);
        Usuario Update(Usuario usuario);
        void Delete(int id);

    }
}
