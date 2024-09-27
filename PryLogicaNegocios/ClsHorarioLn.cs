using PryAccesoDatos;
using PryEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryLogicaNegocios
{
    public class ClsHorarioLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsHorario ObjHorario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Horario",
                NombreSP = "[SP_Horario_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjHorario);
        }

        #endregion

        private void Ejecutar(ref ClsHorario ObjHorario)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjHorario.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjHorario.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjHorario.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjHorario.DtResultados.Rows)
                        {
                            ObjHorario.ID_Horario1 = item["ID_Horario"].ToString();
                            ObjHorario.Hora_Entrada1 = TimeSpan.Parse(item["Hora_Entrada"].ToString());
                            ObjHorario.Hora_Salida1 = TimeSpan.Parse(item["Hora_Salida"].ToString());
                            ObjHorario.Especialidad1 = item["Especialidad"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjHorario.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        public void Create(ref ClsHorario ObjHorario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Horario",
                NombreSP = "[SP_Horario_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Horario", "15", ObjHorario.ID_Horario1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Entrada", "12", ObjHorario.Hora_Entrada1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Salida", "12", ObjHorario.Hora_Salida1);
            ObjDataBase.DtParametros.Rows.Add(@"@Especialidad", "15", ObjHorario.Especialidad1);

            Ejecutar(ref ObjHorario);
        }

        public void Update(ref ClsHorario ObjHorario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Horario",
                NombreSP = "[SP_Horario_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Horario", "15", ObjHorario.ID_Horario1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Entrada", "12", ObjHorario.Hora_Entrada1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Salida", "12", ObjHorario.Hora_Salida1);
            ObjDataBase.DtParametros.Rows.Add(@"@Especialidad", "15", ObjHorario.Especialidad1);

            Ejecutar(ref ObjHorario);
        }

        public void Delete(ref ClsHorario ObjHorario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Horario",
                NombreSP = "[SP_Horario_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Horario", "15", ObjHorario.ID_Horario1);
            Ejecutar(ref ObjHorario);
        }

        public void Read(ref ClsHorario ObjHorario)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Horario",
                NombreSP = "[SP_Horario_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Horario", "15", ObjHorario.ID_Horario1);

            Ejecutar(ref ObjHorario);
        }
        #endregion
    }
}
