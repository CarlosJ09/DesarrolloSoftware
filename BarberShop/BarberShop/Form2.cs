using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarberShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        SqlConnection cn = new SqlConnection("Data Source=CARLOS-DESKTOP;Initial Catalog=Barberia;Integrated Security=True");

        public void LlenarTabla()
        {
            string consulta = "select *from Clientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
            DataTable dt = new();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtTelefono.Text = dataGridView1.SelectedCells[2].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consulta = "insert into Clientes values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtTelefono.Text + "')";
            SqlCommand cm = new(consulta, cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");

            LlenarTabla();

            cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consulta = "delete from Clientes where nombre='" + txtNombre.Text + "'";
            SqlCommand cm = new(consulta, cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");

            LlenarTabla();

            cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consulta = "update Clientes set nombre='" + txtNombre.Text + "',apellido='" + txtApellido.Text + "',telefono='" + txtTelefono.Text + "'";
            SqlCommand cm = new(consulta, cn);
            int cant;

            cant = cm.ExecuteNonQuery();

            if(cant > 0)
            {
                MessageBox.Show("Registro Modificado");
            }
            LlenarTabla();

            cn.Close();
        }
    }
}
