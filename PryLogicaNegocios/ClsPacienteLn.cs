using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PryAccesoDatos;
using PryEntidades;


namespace PryLogicaNegocios
{
    public class ClsPacienteLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjPaciente);
        }

        #endregion

        private void Ejecutar(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPaciente.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPaciente.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPaciente.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjPaciente.DtResultados.Rows)
                        {
                            ObjPaciente.Documento_Pa1 = item["Doc_Paciente"].ToString();
                            ObjPaciente.Tipo_documento1 = item["Tipo_documento"].ToString();
                            
                        }
                    }
                }
            }
            else
            {
                ObjPaciente.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        public void Create(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjPaciente.Documento_Pa1);
            ObjDataBase.DtParametros.Rows.Add(@"@Tipo_documento", "15", ObjPaciente.Tipo_documento1);
          

            Ejecutar(ref ObjPaciente);
        }

        public void Update(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Tipo_documento", "15", ObjPaciente.Tipo_documento1);
            ObjDataBase.DtParametros.Rows.Add(@"Doc_Paciente", "15", ObjPaciente.Documento_Pa1);
           

            Ejecutar(ref ObjPaciente);
        }

        public void Delete(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjPaciente.Documento_Pa1);
            Ejecutar(ref ObjPaciente);
        }

        public void Read(ref ClsPaciente ObjPaciente)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Paciente",
                NombreSP = "[SP_Paciente_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjPaciente.Documento_Pa1);

            Ejecutar(ref ObjPaciente);
        }
        #endregion
    }
}
