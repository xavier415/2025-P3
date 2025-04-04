using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;  
using DAL;  


namespace CRUD_Project
{
    public partial class Form1 : Form
    {
        private UsuarioBLL usuarioBLL;
        public Form1()
        {
            InitializeComponent();
            usuarioBLL = new UsuarioBLL();  // Inicializar la capa BLL
            CargarUsuarios();  // Cargar los usuarios al iniciar
        }

        private void CargarUsuarios()
        {
            // Cargar la lista de usuarios en el DataGridView
            dataGridView1.DataSource = usuarioBLL.ObtenerUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los campos de texto
            string nombre = Nombre.Text;
            string correo = Correo.Text;

            // Validar que los campos no estén vacíos
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(correo))
            {
                // Llamar al método para insertar el usuario
                usuarioBLL.InsertarUsuario(nombre, correo);

                // Recargar los datos en el DataGridView
                CargarUsuarios();

                // Limpiar los campos de texto
                Nombre.Clear();
                Correo.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre y correo válidos.");
            }

        }
    }
}
