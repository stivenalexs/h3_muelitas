using PryAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PryAccesoDatos;
using PryEntidades;
using System.Data;

namespace PryLogicaNegocios
{
    public class ClsHistorial_clinicoLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsHistorial_clinico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Historial_Clinico",
                NombreSP = "[SP_Historial_Clinico_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjHistorial);
        }

        #endregion

        #region MetodoEjecutar
        private void Ejecutar(ref ClsHistorial_clinico ObjHistorial)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjHistorial.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjHistorial.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjHistorial.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjHistorial.DtResultados.Rows)
                        {
                            ObjHistorial.Doc_Paciente1 = item["Doc_Paciente"].ToString();
                            ObjHistorial.Orden1 = item["Orden"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjHistorial.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }
        #endregion

        #region  MetodosCrud
        public void Create(ref ClsHistorial_clinico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Historial_Clinico",
                NombreSP = "[SP_Historial_Clinico_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjHistorial.Doc_Paciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Orden", "15", ObjHistorial.Orden1);

            Ejecutar(ref ObjHistorial);
        }

        public void Update(ref ClsHistorial_clinico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Historial_Clinico",
                NombreSP = "[SP_Historial_Clinico_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjHistorial.Doc_Paciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Orden", "15", ObjHistorial.Orden1);

            Ejecutar(ref ObjHistorial);
        }

        public void Delete_P(ref ClsHistorial_clinico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Historial_Clinico",
                NombreSP = "[SP_Historial_Clinico_Delete_p]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjHistorial.Doc_Paciente1);
            Ejecutar(ref ObjHistorial);
        }
        public void Delete_p_O(ref ClsHistorial_clinico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Historial_Clinico",
                NombreSP = "[SP_Historial_Clinico_Delete_o]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Orden", "15", ObjHistorial.Orden1);
            Ejecutar(ref ObjHistorial);
        }

        public void Read(ref ClsHistorial_clinico ObjHistorial)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Historial_Clinico",
                NombreSP = "[SP_Historial_Clinico_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjHistorial.Doc_Paciente1);

            Ejecutar(ref ObjHistorial);
        }
        #endregion
    }
}
