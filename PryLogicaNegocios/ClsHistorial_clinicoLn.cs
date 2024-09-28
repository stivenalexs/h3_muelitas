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
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Historial_Clinico" mediante el procedimiento almacenado.
        // El objeto ClsHistorial_Clinico se pasa por referencia y será actualizado con los datos obtenidos.
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
            // Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase); 

            // En caso de no haber errores, comienza a procesar los resultados.
            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                // Si el resultado es un valor escalar, este lo va a asignar al Historial.
                if (ObjDataBase.Scalar)
                {
                    ObjHistorial.ValorScalar = ObjDataBase.ValorScalar;
                }
                else // Si es una tabla de datos, la asigna a cita y extrae los valores
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
            else // Se genera el mensaje de error
            {
                ObjHistorial.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }
        #endregion

        #region  MetodosCrud
        // Método Create, crea un registro en la tabla "Historial_Clinico" utilizando el procedimiento almacenado.
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
        // Método Update, actualiza un registro en la tabla "Historial_Clinico" utilizando el procedimiento almacenado.
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

        // El método `Delete_P` elimina un registro de "Historial_Clinico" usando el procedimiento almacenado
        // pasando como parámetro el `Doc_Paciente` del objeto `ObjHistorial`.
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
        // El método `Delete_p_O` también elimina un registro de "Historial_Clinico", pero usa el procedimiento almacenado 
        // pasando como parámetro el `Orden` del objeto `ObjHistorial`.
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
        // Método Read, lee un registro en la tabla "Historial_Clinico" utilizando el procedimiento almacenado.
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
