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
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Horario" mediante el procedimiento almacenado.
        // El objeto ClsHorario se pasa por referencia y será actualizado con los datos obtenidos.
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
            // Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados.
            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar) // Si el resultado es un valor escalar, este lo va a asignar al Horario.
                {
                    ObjHorario.ValorScalar = ObjDataBase.ValorScalar;
                }
                else // Si es una tabla de datos, la asigna a horario y extrae los valores
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
            else // Muestra de Mensaje de error.
            {
                ObjHorario.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        // Método CREATE, crea un registro en la tabla "Horario." utilizando el procedimiento almacenado.
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
        // Método UPDATE, actualiza un registro en la tabla "Horario." utilizando el procedimiento almacenado.
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
        // Método DELETE, elimina un registro en la tabla "Horario." utilizando el procedimiento almacenado.
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
        // Método READ, lee un registro en la tabla "Horario." utilizando el procedimiento almacenado.
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
