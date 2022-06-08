using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form2 : Form
    {
        Pacientes pacientes = new Pacientes();
        private int indice = -1;
        private List<Pacientes> Pacientes = new List<Pacientes>();
       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pacientes.Nombre = txtNombre.Text;
            pacientes.Apellido = txtApellido.Text;
            pacientes.Telefono = txtTelefono.Text;
            pacientes.Fecha = dateTime1.Value;

            if (indice > -1)
            {
                Pacientes[indice] = pacientes;
                indice = -1;
            }
            else
            {
                Pacientes.Add(pacientes);
            }
            Limpiar();
            Actualizar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           
        }
        private void Limpiar()
        {
            txtNombre.Text = null;
            txtTelefono.Text = null;
            txtApellido.Text = null;

        }

        private void Actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Pacientes;
            dataGridView1.ClearSelection();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                Pacientes.RemoveAt(indice);
                Actualizar();
                Limpiar();
                indice = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para borrar");
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

      
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_DoubleClick_2(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(renglon);
            Pacientes pacientes = Pacientes[indice];
            txtNombre.Text = pacientes.Nombre;
            txtTelefono.Text = pacientes.Telefono;
            txtApellido.Text = pacientes.Apellido;
            dateTime1.Value = pacientes.Fecha;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow renglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(renglon);
            Pacientes pacientes = Pacientes[indice];
            txtNombre.Text = pacientes.Nombre;
            txtTelefono.Text = pacientes.Telefono;
            txtApellido.Text = pacientes.Apellido;
            dateTime1.Value = pacientes.Fecha;
        }
    }
}
