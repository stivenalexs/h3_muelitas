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
        ClsPersona persona = new ClsPersona();
        Panel panel;
        public FrmAgendar(ClsPersona person, Panel pa)
        {
            InitializeComponent();
            persona = person;
            panel = pa;
        }

        private void FrmAgendar_Load(object sender, EventArgs e)
        {
            cmb_tipocita.Items.Add("Odontología general");
            cmb_tipocita.Items.Add("Cirugía maxilofacial");
            cmb_tipocita.Items.Add("Odontopediatría");
            cmb_tipocita.Items.Add("Ortodoncia");
            cmb_tipocita.Items.Add("Periodoncia");
            cmb_tipocita.Items.Add("Prostodoncia");
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
