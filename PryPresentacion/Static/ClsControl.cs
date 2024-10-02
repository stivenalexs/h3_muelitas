using PryEntidades;
using PryLogicaNegocio;
using PryLogicaNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPresentacion.Static
{
    public class ClsControl
    {

        public static void solo_letras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                MessageBox.Show("solo se pueden ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        public static void solo_numeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo se pueden ingresar numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        public static void identificar(ClsPersona p, ClsPersonaLn pln,ClsPaciente pa,ClsPacienteLn paln,
            ClsProfecional pro,ClsProfecionalLn proln,ClsAdministrador admin, ClsAdministradorLn adminln)
        {
            pa.Documento_Pa1 = p.ID_Persona1;
            pro.Documento_Pro1 = p.ID_Persona1;
            admin.ID_Persona1 = p.ID_Persona1;
            paln.Read(ref pa);
            proln.Read(ref pro);
            adminln.Read(ref admin);
        }
        public static void AbrirFormulario(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }
        public static void LlenarComboBox(ClsProfecional ObjProfesional, ComboBox c)
        {
            // Asegúrase de que DtResultados no sea nulo y tenga filas
            if (ObjProfesional.DtResultados != null && ObjProfesional.DtResultados.Rows.Count > 0)
            {
                // Limpia el ComboBox antes de llenarlo
                c.Items.Clear();

                // Itera sobre cada fila en DtResultados
                foreach (DataRow fila in ObjProfesional.DtResultados.Rows)
                {
                    // Supongamos que la columna que deseas mostrar en el ComboBox se llama "Nombre"
                    string nombreProfesional = fila["Nombre"].ToString();
                    c.Items.Add(nombreProfesional);
                }
            }
            else
            {
                c.Items.Clear();
                // Maneja el caso donde no hay resultados
                c.Items.Add("No hay profesionales disponibles");
            }
        }
    }
}
