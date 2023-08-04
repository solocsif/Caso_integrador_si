using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Gestion_de_Inmueble : Form
    {
        Inmuebles Enviar = new Inmuebles();
        public Gestion_de_Inmueble()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gestion_de_Inmueble_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio index = new Inicio();
            index.Show();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Enviar.pTipo= Desplegable.Text;
            Enviar.pMatricula=Matricula.Text;
            Enviar.pDireccion=Direccion.Text;
            Enviar.pTelefono=Telefono.Text;
            Enviar.pBarrio=Barrio.Text;
            Enviar.pZona=Zona.Text;
            Enviar.pPrecio=Precio.Text;
            Enviar.pDescripcion=Descripcion.Text;
            Enviar.Show();

        }
    }
}
