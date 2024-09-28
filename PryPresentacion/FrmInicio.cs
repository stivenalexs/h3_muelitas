using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPresentacion
{
    public partial class FrmInicio : MaterialForm
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            ClsPersona persona = new ClsPersona(txb_usuario.Text,txb_contraseña.Text);
            ClsPersonaLn lnpersona = new ClsPersonaLn();
            lnpersona.Validar(ref persona);
            if (persona.MensajeError==null)
            {
                if (persona.DtResultados.Rows.Count > 0)
                {
                    MessageBox.Show("bienvenido pai ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPerfil perfil = new FrmPerfil(persona,this);
                    perfil.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(persona.MensajeError, "Usuario y/o Contraseña incorrecta ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro(this);
            registro.Show();
            this.Hide();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            btn_registrar.Visible = false;
            btn_ingresar.Visible = false;
            btn_registrar.Enabled = false;
            btn_ingresar.Enabled = false;
            //
            txb_usuario.Visible = true;
            txb_contraseña.Visible = true;
            btn_iniciar.Visible = true;
            txb_usuario.Enabled = true;
            txb_contraseña.Enabled = true;
            btn_iniciar.Enabled = true;
        }
    }
}
