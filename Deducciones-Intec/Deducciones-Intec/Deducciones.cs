namespace Deducciones_Intec
{
    public partial class Deducciones : Form
    {
        public Deducciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double AFP = 0.0287D;
            double SFS = 0.0304D;
            double TotalD = AFP - SFS;
            double SueldoB = double.Parse(txt_SueldoB.Text);

            if (SueldoB < 34609)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }

            if (SueldoB > 34685 && SueldoB <= 52027)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }

            if (SueldoB > 52027 && SueldoB <= 72260)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }

            if (SueldoB > 72260)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }
        }
        public static double Afp(double SueldoBruto)
        {
            double a = Math.Round(SueldoBruto * 0.0287, 2);
            return a;
        }

        public static double Sfs(double SueldoBruto)
        {
            double a = Math.Round(SueldoBruto * 0.0304, 2);
            return a;
        }

        public static double Totaldescuentos(double SueldoBru, double TotalD)
        {
            double a = Math.Round(Afp(SueldoBru) + Sfs(SueldoBru) + Isr(SueldoBru, TotalD), 2);
            return a;
        }

        public static double SueldoNe(double SueldoBruto, double TotalD)
        {
            double a = Math.Round(SueldoBruto - Totaldescuentos(SueldoBruto, TotalD), 2);
            return a;
        }

        public static double Isr(double SueldoBruto, double TotalD)
        {
            while (true)
            {
                if (SueldoBruto < 34609)
                {
                    double a = 0;
                    return a;
                }
                if (SueldoBruto > 34685 && SueldoBruto <= 52027)
                {

                    double a = Math.Round(((((SueldoBruto - TotalD) * 12) - 416220.01) * 0.15) / 12, 2);
                    return a;
                }

                if (SueldoBruto > 52027 && TotalD <= 72260)
                {
                    double a = Math.Round(((((SueldoBruto - TotalD) * 12) - 624329.01) * 0.20) / 12, 2);
                    return a;
                }

                if (SueldoBruto > 72260)
                {
                    double a = Math.Round(((((SueldoBruto - TotalD) * 12) - 867123.01) * 0.25) / 12, 2);
                    return a;
                }
            }
        }
        private void txt_SueldoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_SueldoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deducciones_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_DiaHora.Text = dt.ToString("F");
        }

        private void txt_ISR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}