using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistemas_de_Pedidos
{
    //NOMBRE: STEPHANIE MARIELA FLORES CASTRO
    //NO. CUENTA: 20181001362

    public partial class PrincipalForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        //CREACION DE LISTA QUE SE CARGARÁ EN EL DATAGRIPVIEW
        List<Descripcion> DescripcionLista = new List<Descripcion>();

        private int CalculoTotal(int n1, int n2)
        {
            int num1 = n1;
            int num2 = n2;

            int resultado = num1 * num2;

            return resultado;
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            if (PreciotextBox.Text == "")
            {
                errorProvider1.SetError(PreciotextBox, "Ingrese Precio");
                PreciotextBox.Focus();
            }

            if (CantidadtextBox.Text == "")
            {
                errorProvider1.SetError(CantidadtextBox, "Ingrese Cantidad");
                CantidadtextBox.Focus();
            }

            int resultadoM = CalculoTotal(Convert.ToInt32(PreciotextBox.Text), Convert.ToInt32(CantidadtextBox.Text));
            TotaltextBox.Text = resultadoM.ToString();
        }

        private void Confirmacionbutton_Click(object sender, EventArgs e)
        {
            if (NomClientetextBox.Text == "")
            {
                errorProvider1.SetError(NomClientetextBox, "Ingrese Nombre de Cliente");
                NomClientetextBox.Focus();
            }

            if (DirecciontextBox.Text == "")
            {
                errorProvider1.SetError(DirecciontextBox, "Ingrese Dirección");
                DirecciontextBox.Focus();
            }

            if (PresentaciontextBox.Text == "")
            {
                errorProvider1.SetError(PresentaciontextBox, "Ingrese Presentacion");
                PresentaciontextBox.Focus();
            }

            if (MedicamentotextBox.Text == "")
            {
                errorProvider1.SetError(MedicamentotextBox, "Ingrese el medicamento");
                MedicamentotextBox.Focus();
            }

            if (TipoMedicamentotextBox.Text == "")
            {
                errorProvider1.SetError(TipoMedicamentotextBox, "Ingrese el tipo de medicamento");
                TipoMedicamentotextBox.Focus();
            }

            if (MessageBox.Show("¿Desea confimar su pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Descripcion DescripcionTotal = new Descripcion();
                Descripcion DescripcionTotal = new Descripcion(NomClientetextBox.Text, DirecciontextBox.Text, PresentaciontextBox.Text, MedicamentotextBox.Text, TipoMedicamentotextBox.Text, Convert.ToInt32(PresentaciontextBox.Text), Convert.ToInt32(PresentaciontextBox.Text), Convert.ToInt32(TotaltextBox.Text));

                DescripcionLista.Add(DescripcionTotal);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DescripcionLista;
            }

            //LIMPIEZA DE CONTROLES
            NomClientetextBox.Clear();
            DirecciontextBox.Clear();
            PresentaciontextBox.Clear();
            MedicamentotextBox.Clear();
            TipoMedicamentotextBox.Clear();
            PreciotextBox.Clear();
            CantidadtextBox.Clear();
            TotaltextBox.Clear();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
