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
    
    public class ClsAdministradorLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex

        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Administrador" mediante el procedimiento almacenado.
        // El objeto ClsAdministrador se pasa por referencia y será actualizado con los datos obtenidos.
        public void Index(ref ClsAdministrador ObjAdministrador)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Administrador",
                NombreSP = "[SP_Administrador_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjAdministrador);
        }

        #endregion

        private void Ejecutar(ref ClsAdministrador ObjAdministrador)
        {
            // Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados.
            if (ObjDataBase.MensajeErrorOS == null) 
            {
                // Si el resultado es un valor escalar, este lo va a asignar al administrador.
                if (ObjDataBase.Scalar)
                {
                    ObjAdministrador.ValorScalar = ObjDataBase.ValorScalar;
                }
                // Si es una tabla de datos, la asigna al administrador y extrae los valores
                else
                {
                    ObjAdministrador.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjAdministrador.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjAdministrador.DtResultados.Rows)
                        {
                            ObjAdministrador.ID_Persona1 = item["ID_Persona"].ToString();
                            ObjAdministrador.Clave1 = item["Clave"].ToString();
                        }
                    }
                }
            }
            else // Se genera el mensaje de error
            {
                ObjAdministrador.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        // Método CREATE, crea un registro en la tabla "Administrador" utilizando el procedimiento almacenado.
        public void Create(ref ClsAdministrador ObjAdministrador)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Administrador",
                NombreSP = "[SP_Administrador_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Persona", "15", ObjAdministrador.ID_Persona1);
            ObjDataBase.DtParametros.Rows.Add(@"@Clave", "15", ObjAdministrador.Clave1);

            Ejecutar(ref ObjAdministrador);
        }
        // Método UPDATE, actualiza un registro en la tabla "Administrador" utilizando el procedimiento almacenado.
        public void Update(ref ClsAdministrador ObjAdministrador)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Administrador",
                NombreSP = "[SP_Administrador_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Persona", "15", ObjAdministrador.ID_Persona1);
            ObjDataBase.DtParametros.Rows.Add(@"@Clave", "15", ObjAdministrador.Clave1);

            Ejecutar(ref ObjAdministrador);
        }
        // Método DELETE , elimina un registro en la tabla "Administrador" utilizando el procedimiento almacenado.
        public void Delete(ref ClsAdministrador ObjAdministrador)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Administrador",
                NombreSP = "[SP_Administrador_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Persona", "15", ObjAdministrador.ID_Persona1);
            Ejecutar(ref ObjAdministrador);
        }

        // Método READ, lee un registro en la tabla "Administrador" utilizando el procedimiento almacenado.
        public void Read(ref ClsAdministrador ObjAdministrador)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Administrador",
                NombreSP = "[SP_Administrador_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Persona", "15", ObjAdministrador.ID_Persona1);

            Ejecutar(ref ObjAdministrador);
        }
        #endregion
    }
}
