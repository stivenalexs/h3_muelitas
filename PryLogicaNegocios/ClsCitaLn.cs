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
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Cita" mediante el procedimiento almacenado.
        // El objeto ClsCita se pasa por referencia y será actualizado con los datos obtenidos.
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
            // Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados.
            if (ObjDataBase.MensajeErrorOS == null) 
            {
                // Si el resultado es un valor escalar, este lo va a asignar al Cita.
                if (ObjDataBase.Scalar)
                {
                    ObjCita.ValorScalar = ObjDataBase.ValorScalar;
                }
                // Si es una tabla de datos, la asigna a cita y extrae los valores
                else
                {
                    ObjCita.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjCita.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjCita.DtResultados.Rows)
                        {
                            ObjCita.Cod_Cita1 = item["Cod_Cita"].ToString();
                            ObjCita.Doc_Paciente1 = item["Doc_Paciente"].ToString();
                            ObjCita.Doc_Profesional1 = item["Doc_Profesional"].ToString();
                            ObjCita.Fecha_Cita1 = Convert.ToDateTime(item["Fecha_Cita"].ToString());
                            ObjCita.Hora_Cita1 = TimeSpan.Parse(item["Hora_Cita"].ToString());
                            ObjCita.Estado1 = item["Estado"].ToString();
                        }
                    }
                }
            }
            else // Se genera el mensaje de error
            {
                ObjCita.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud

        // Método CREATE, crea un registro en la tabla "Cita" utilizando el procedimiento almacenado.
        public void Create(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "15", ObjCita.Cod_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjCita.Doc_Paciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Profesional", "15", ObjCita.Doc_Profesional1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Cita", "11", ObjCita.Fecha_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Cita", "12", ObjCita.Hora_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "15", ObjCita.Estado1);

            Ejecutar(ref ObjCita);
        }
        // Método Update, actualiza un registro en la tabla "Cita" utilizando el procedimiento almacenado.
        public void Update(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "15", ObjCita.Cod_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Paciente", "15", ObjCita.Doc_Paciente1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Profesional", "15", ObjCita.Doc_Profesional1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Cita", "11", ObjCita.Fecha_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_Cita", "12", ObjCita.Hora_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "15", ObjCita.Estado1);

            Ejecutar(ref ObjCita);
        }
        // Método DELETE, elimina un registro en la tabla "Cita" utilizando el procedimiento almacenado.
        public void Delete(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "15", ObjCita.Cod_Cita1);
            Ejecutar(ref ObjCita);
        }
        // Método READ, lee un registro en la tabla "Cita" utilizando el procedimiento almacenado.
        public void Read(ref ClsCita ObjCita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Cita",
                NombreSP = "[SP_Cita_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "15", ObjCita.Cod_Cita1);

            Ejecutar(ref ObjCita);
        }
        #endregion
    }
}
