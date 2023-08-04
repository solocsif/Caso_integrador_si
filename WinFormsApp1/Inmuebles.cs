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
    public partial class Inmuebles : Form
    {
        public string Tipo, Matricula, Direccion, Telefono, Barrio, Zona, Precio, Descripcion;

        public string pTipo
        {
            set
            {
                Tipo = value;
            }
        }

        public string pMatricula
        {
            set
            {
                Matricula = value;
            }
        }

        public string pDireccion
        {
            set
            {
                Direccion = value;
            }
        }

        public string pTelefono
        {
            set
            {
                Telefono = value;
            }
        }

        public string pBarrio
        {
            set
            {
                Barrio = value;
            }
        }

        public string pZona
        {
            set
            {
                Zona = value;
            }
        }

        public string pPrecio
        {
            set
            {
                Precio = value;
            }
        }

        public string pDescripcion
        {
            set
            {
                Descripcion = value;
            }
        }
        public Inmuebles()
        {
            InitializeComponent();
        }

        private void Inmuebles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Registro = dataGridView1.Rows.Add();
            dataGridView1.Rows[Registro].Cells["CTipo"].Value = Tipo;
            dataGridView1.Rows[Registro].Cells["CMatricula"].Value = Matricula;
            dataGridView1.Rows[Registro].Cells["CDireccion"].Value = Direccion;
            dataGridView1.Rows[Registro].Cells["CTelefono"].Value = Telefono;
            dataGridView1.Rows[Registro].Cells["CBarrio"].Value = Barrio;
            dataGridView1.Rows[Registro].Cells["CZona"].Value = Zona;
            dataGridView1.Rows[Registro].Cells["CPrecio"].Value = Precio;
            dataGridView1.Rows[Registro].Cells["CDescripcion"].Value = Descripcion;
        }
    }
}
