namespace Clinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtContra.Text;

            if (usuario == "Platano" && contra == "12345")
            {
                Form2 form = new Form2();
                form.Visible = true;
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("El usuario y contraseña son incorrectos!");
            }
        }
    }
}