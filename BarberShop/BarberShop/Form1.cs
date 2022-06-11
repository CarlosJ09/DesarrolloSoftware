using System.Data.SqlClient;

namespace BarberShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection conexion()
        {
            SqlConnection cn = new SqlConnection("Data Source=CARLOS-DESKTOP;Initial Catalog=Barberia;Integrated Security=True");

            cn.Open();
            SqlCommand cm = new SqlCommand("select usuario,contraseña from Login where usuario='" +txtUsuario.Text + "' and contraseña='" +txtContra.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bienvenido de nuevo :)");
                Form2 fr = new();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o contraseña son incorrectos :(");
            }
            return cn;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion();
        }
    }
}