namespace WinFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_de_Inmueble GDI = new Gestion_de_Inmueble();
            GDI.Show();
        }

        private void GestionDeInmuebles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_de_Inmueble GDI = new Gestion_de_Inmueble();
            GDI.Show();
        }
    }
}