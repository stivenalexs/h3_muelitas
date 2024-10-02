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
    public class ClsCitaLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjCita);
        }

        #endregion

        private void Ejecutar(ref ClsCita ObjCita)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjCita.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjCita.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjCita.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjCita.DtResultados.Rows)
                        {
                            ObjCita.Cod_Cita1 =int.Parse( item["Cod_Cita"].ToString());
                            ObjCita.Doc_Paciente1 = item["Doc_Paciente"].ToString();
                            ObjCita.Doc_Profesional1 = item["Doc_Profesional"].ToString();
                            ObjCita.Fecha_Cita1 = Convert.ToDateTime(item["Fecha_Cita"].ToString());
                            ObjCita.Hora_Cita1 = TimeSpan.Parse(item["Hora_Cita"].ToString());
                            ObjCita.Estado1 = item["Estado"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjCita.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        public void Create(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjCita.Doc_Paciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Profesional", "15", ObjCita.Doc_Profesional1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Cita", "11", ObjCita.Fecha_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Cita", "12", ObjCita.Hora_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "15", ObjCita.Estado1);

            Ejecutar(ref ObjCita);
        }

        public void Update(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "4", ObjCita.Cod_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjCita.Doc_Paciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Profesional", "15", ObjCita.Doc_Profesional1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Cita", "11", ObjCita.Fecha_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Cita", "12", ObjCita.Hora_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "15", ObjCita.Estado1);

            Ejecutar(ref ObjCita);
        }

        public void Delete(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "4", ObjCita.Cod_Cita1);
            Ejecutar(ref ObjCita);
        }

        public void Read(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "4", ObjCita.Cod_Cita1);

            Ejecutar(ref ObjCita);
        }
        #endregion

        #region metodos especificos
        public void Buscar_Citas_Paciente(ref ClsCita ObjCita, string documento)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Buscar_CitaPa]",
                Scalar = false
            };

            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", documento);
            Ejecutar(ref ObjCita);
        }
        public void Reprogramar(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Reprogramar]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "4", ObjCita.Cod_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Profesional", "15", ObjCita.Doc_Profesional1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Cita", "11", ObjCita.Fecha_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Cita", "12", ObjCita.Hora_Cita1);

            Ejecutar(ref ObjCita);
        }
        #endregion
    }
}
