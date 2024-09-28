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
    public class ClsProcedimientoLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Procedimiento" mediante el procedimiento almacenado.
        // El objeto ClProcedimiento pasa por referencia y será actualizado con los datos obtenidos.
        public void Index(ref ClsProcedimiento ObjProcedimiento)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Procedimiento",
                NombreSP = "[SP_Procedimiento_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjProcedimiento);
        }
        #endregion

        #region Metodoejecutar
        private void Ejecutar(ref ClsProcedimiento ObjProcedimiento)
        {
            //Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados
            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar) // Si el resultado es un valor escalar, este lo va a asignar a Procedimiento.
                {
                    ObjProcedimiento.ValorScalar = ObjDataBase.ValorScalar;
                }
                else // Si es una tabla de datos, la asigna a procedimiento y extrae los valores
                {
                    ObjProcedimiento.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjProcedimiento.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjProcedimiento.DtResultados.Rows)
                        {
                            ObjProcedimiento.Cod_Procedimiento1 = item["Cod_Procedimiento"].ToString();
                            ObjProcedimiento.Tipo_P1 = item["Tipo_P"].ToString();
                            ObjProcedimiento.Fecha_P1 = Convert.ToDateTime(item["Fecha_P"].ToString());
                            ObjProcedimiento.Hora_P1 = TimeSpan.Parse(item["Hora_P"].ToString());
                            ObjProcedimiento.Estado_P1 = item["Estado_P"].ToString();
                            ObjProcedimiento.Pro_Asignado1 = item["Pro_Asignado"].ToString();

                        }
                    }
                }
            }
            else // Genera mensaje de error.
            {
                ObjProcedimiento.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }
        #endregion

        #region  MetodosCrud
        // Método CREATE, crea un registro en la tabla "procedimiento" utilizando el procedimiento almacenado.
        public void Create(ref ClsProcedimiento ObjProcedimiento)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Procedimiento",
                NombreSP = "[SP_Procedimiento_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Procedimiento", "15", ObjProcedimiento.Cod_Procedimiento1);
            ObjDataBase.DtParametros.Rows.Add(@"@Tipo_P", "15", ObjProcedimiento.Tipo_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_P", "11", ObjProcedimiento.Fecha_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_P", "12", ObjProcedimiento.Hora_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado_P", "15", ObjProcedimiento.Estado_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Pro_Asignado", "15", ObjProcedimiento.Pro_Asignado1);


            Ejecutar(ref ObjProcedimiento);
        }
        // Método Update, actualiza un registro en la tabla "procedimiento" utilizando el procedimiento almacenado.
        public void Update(ref ClsProcedimiento ObjProcedimiento)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Procedimiento",
                NombreSP = "[SP_Patrones_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Procedimiento", "15", ObjProcedimiento.Cod_Procedimiento1);
            ObjDataBase.DtParametros.Rows.Add(@"@Tipo_P", "15", ObjProcedimiento.Tipo_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_P", "11", ObjProcedimiento.Fecha_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Hora_P", "12", ObjProcedimiento.Hora_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado_P", "15", ObjProcedimiento.Estado_P1);
            ObjDataBase.DtParametros.Rows.Add(@"@Pro_Asignado", "15", ObjProcedimiento.Pro_Asignado1);

            Ejecutar(ref ObjProcedimiento);
        }
        // Método DELETE, elimina un registro en la tabla "procedimiento" utilizando el procedimiento almacenado.
        public void Delete(ref ClsProcedimiento ObjProcedimiento)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Procedimiento",
                NombreSP = "[SP_Patrones_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Procedimiento", "15", ObjProcedimiento.Cod_Procedimiento1);
            Ejecutar(ref ObjProcedimiento);
        }
        // Método READ, lee un registro en la tabla "procedimiento" utilizando el procedimiento almacenado.
        public void Read(ref ClsProcedimiento ObjProcedimiento)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Procedimiento",
                NombreSP = "[SP_Patrones_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Procedimiento", "15", ObjProcedimiento.Cod_Procedimiento1);

            Ejecutar(ref ObjProcedimiento);
        }
        #endregion
    }
}
