using CRUDprueba.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDprueba
{
    public partial class Form1 : Form
    {

        CrudpruebaContext crudpruebaContext;

        public Form1()
        {
            InitializeComponent();
            crudpruebaContext = new CrudpruebaContext();
            crudpruebaContext.Database.EnsureCreated();
            crudpruebaContext.Database.Migrate();


            datosClientes.DataSource = crudpruebaContext.Clientes.ToList();
            datosClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vendedor vende = new Vendedor()
            {
                Nombre = tNombre.Text,
                Apellido = tApellido.Text,
                Correo = tCorreo.Text,
            };
            Cliente client = new Cliente()
            {
                Nombre = tNombre.Text,
                Apellido = tApellido.Text,
                Correo = tCorreo.Text,
            };

            crudpruebaContext.Clientes.Add(client);
            crudpruebaContext.Vendedores.Add(vende);
            crudpruebaContext.SaveChanges();
            MessageBox.Show("Agregado correctamente!!");

            tApellido.Text = String.Empty;
            tNombre.Text = String.Empty;
            tCorreo.Text = String.Empty;
        }
    }
}