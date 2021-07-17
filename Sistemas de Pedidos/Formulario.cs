using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_Pedidos
{
    //NOMBRE: STEPHANIE MARIELA FLORES CASTRO
    //NO. CUENTA: 20181001362

    public partial class Formulario : Syncfusion.Windows.Forms.Office2010Form 
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            //VALIDACIONES DE USUARIO
            if (UsuariotextBox.Text == " ")
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese Usuario");
                UsuariotextBox.Focus();
            }
            errorProvider1.SetError(UsuariotextBox, "");

            
            //VALIDACIONES DE CONTRASEÑA
            if (ContraseñatextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese la contraseña");
                ContraseñatextBox.Focus();
                return;
            }
            errorProvider1.SetError(ContraseñatextBox, "");

            //LLAMAMOS AL FORMULARIO DE TRASLADO
            PrincipalForm formularioP = new PrincipalForm();

            //OCULTA EL FORMULARIO DONDE NOS ENCONTRAMOS
            this.Hide();
            formularioP.Show();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
