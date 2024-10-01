using MaterialSkin.Controls;
using PryEntidades;
using PryLogicaNegocios;
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
    public partial class FrmAgendar : Form
    {
        public FrmAgendar()
        {
            InitializeComponent();
        }

        private void FrmAgendar_Load(object sender, EventArgs e)
        {

        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {

        }

        private void cmb_profesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            //objetos profesional
            ClsProfecional profesional = new ClsProfecional(cmb_profesional.Text, cmb_hora.Text);
            ClsProfecionalLn profecionalLn = new ClsProfecionalLn();
            profecionalLn.Index(ref profesional);
        }
    }
}
