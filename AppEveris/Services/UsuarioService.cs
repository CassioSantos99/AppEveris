using AppEveris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEveris.Services
{
    public class UsuarioService : IUsuarioService
    {
        List<Usuario> usuarios = new List<Usuario>();
        public Usuario Add(Usuario usuario)
        {
            usuario.id = usuarios.Count + 1;
            usuarios.Add(usuario);
            return usuario;
        }

        public void Delete(int id)
        {
            usuarios = usuarios.Where(w => w.id != id).ToList();
        }

        public List<Usuario> Get()
        {
            return usuarios;
        }

        public Usuario Update(Usuario usuario)
        {
            Usuario usuarioExistente = usuarios.Where(w => w.id == usuario.id).FirstOrDefault();
            if(usuarioExistente != null)
            {
                var index = usuarios.IndexOf(usuarioExistente);
                usuarioExistente = usuario;
                usuarios[index] = usuarioExistente;
            }
            return usuarioExistente;
        }
    }
}
