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
    public class ClsOrdenLN
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Nomina" mediante el procedimiento almacenado.
        // El objeto ClNomina se pasa por referencia y será actualizado con los datos obtenidos.
        public void Index(ref ClsOrden ObjOrden)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Orden",
                NombreSP = "[SP_Orden_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjOrden);
        }
        #endregion

        #region MetodoEjecutar
        private void Ejecutar(ref ClsOrden ObjOrden)
        {
            // Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados.
            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar) // Si el resultado es un valor escalar, este lo va a asignar a Orden.
                {
                    ObjOrden.ValorScalar = ObjDataBase.ValorScalar;
                }
                else // Si es una tabla de datos, la asigna a horario y extrae los valores
                {
                    ObjOrden.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjOrden.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjOrden.DtResultados.Rows)
                        {
                            ObjOrden.Cod_Orden1 = item["Cod_Orden"].ToString();
                            ObjOrden.Cod_Cita1 = item["Cod_Cita"].ToString();
                            ObjOrden.Diagnostico1 = item["Diagnostico"].ToString();
                            ObjOrden.Medicamento1 = item["Medicamento"].ToString();
                            ObjOrden.Recomendacion1 = item["Recomendacion"].ToString();
                            ObjOrden.Remision1 = item["Remision"].ToString();
                        }
                    }
                }
            }
            else // Se genera el mensaje de error
            {
                ObjOrden.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }
        #endregion

        #region  MetodosCrud
        // Método CREATE, crea un registro en la tabla "Orden" utilizando el procedimiento almacenado.
        public void Create(ref ClsOrden ObjOrden)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Orden",
                NombreSP = "[SP_Orden_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@@Cod_Orden", "15", ObjOrden.Cod_Orden1);
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "15", ObjOrden.Cod_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Diagnostico", "15", ObjOrden.Diagnostico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Medicamento", "15", ObjOrden.Medicamento1);
            ObjDataBase.DtParametros.Rows.Add(@"@Recomendacion", "15", ObjOrden.Recomendacion1);
            ObjDataBase.DtParametros.Rows.Add(@"@Remision", "15", ObjOrden.Remision1);



            Ejecutar(ref ObjOrden);
        }
        // Método UPDATE, actualiza un registro en la tabla "Orden" utilizando el procedimiento almacenado.
        public void Update(ref ClsOrden ObjOrden)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Orden",
                NombreSP = "[SP_Orden_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Orden", "15", ObjOrden.Cod_Orden1);
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "15", ObjOrden.Cod_Cita1);
            ObjDataBase.DtParametros.Rows.Add(@"@Diagnostico", "15", ObjOrden.Diagnostico1);
            ObjDataBase.DtParametros.Rows.Add(@"@Medicamento", "15", ObjOrden.Medicamento1);
            ObjDataBase.DtParametros.Rows.Add(@"@Recomendacion", "15", ObjOrden.Recomendacion1);
            ObjDataBase.DtParametros.Rows.Add(@"@Remision", "15", ObjOrden.Remision1);

            Ejecutar(ref ObjOrden);
        }
        // Método DELETE, elimina un registro en la tabla "Orden" utilizando el procedimiento almacenado.
        public void Delete(ref ClsOrden ObjOrden)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Orden",
                NombreSP = "[SP_Orden_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Orden", "15", ObjOrden.Cod_Orden1);
            Ejecutar(ref ObjOrden);
        }
        // Método READ, lee un registro en la tabla "Orden" utilizando el procedimiento almacenado.
        public void Read(ref ClsOrden ObjOrden)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Patrones",
                NombreSP = "[SP_Patrones_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Cod_Cita", "15", ObjOrden.Cod_Cita1);

            Ejecutar(ref ObjOrden);
        }
        #endregion

        #region Metodos especificos
        
        #endregion
    }
}
