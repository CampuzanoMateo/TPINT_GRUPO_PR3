using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario
    {
        public int idUsuario {  get; set; }
        public string usuario{ get; set; }
        public string contraseñaUsuario { get; set; }
        public string rolUsuario { get; set; }

        public Usuario() { }

        public Usuario(int id , string usu, string contrase ,  string rol)
        {
            idUsuario = id;
            usuario = usu;
            contraseñaUsuario = contrase;
            rolUsuario = rol;
        }

    }
}
