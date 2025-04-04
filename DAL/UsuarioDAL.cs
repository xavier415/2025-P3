using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        private string connectionString = @"Server=DESKTOP-MSV2RO2\SQLEXPRESS;Database=P3;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        public DataTable ObtenerUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuarios", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertarUsuario(string nombre, string correo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (Nombre, Correo) VALUES (@Nombre, @Correo)", conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Correo", correo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
