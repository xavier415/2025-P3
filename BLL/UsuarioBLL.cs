using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL;

        public UsuarioBLL()
        {
            usuarioDAL = new UsuarioDAL();
        }

        public DataTable ObtenerUsuarios()
        {
            return usuarioDAL.ObtenerUsuarios();
        }

        public void InsertarUsuario(string nombre, string correo)
        {
            usuarioDAL.InsertarUsuario(nombre, correo);
        }
    }
}
