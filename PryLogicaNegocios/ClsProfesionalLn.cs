using PryAccesoDatos;
using PryEntidades;
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
    public class ClsProfecionalLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Procedimiento" mediante el procedimiento almacenado.
        // El objeto ClsProfesional pasa por referencia y será actualizado con los datos obtenidos.
        public void Index(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Profesional",
                NombreSP = "[SP_Profesional_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjProfesional);
        }

        #endregion

        private void Ejecutar(ref ClsProfecional ObjProfesional)
        {
            //Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados
            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar) // Si el resultado es un valor escalar, este lo va a asignar a Profesional.
                {
                    ObjProfesional.ValorScalar = ObjDataBase.ValorScalar;
                }
                else // Si es una tabla de datos, la asigna a profesional y extrae los valores
                {
                    ObjProfesional.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjProfesional.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjProfesional.DtResultados.Rows)
                        {
                            ObjProfesional.Horario1= item["Horario"].ToString();
                            ObjProfesional.Documento_Pro1 = item["Doc_pro"].ToString();
                         
                        }
                    }
                }
            }
            else // Genera Mensaje de error.
            {
                ObjProfesional.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        private void Ejecutar_Horario(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase.CRUD(ref ObjDataBase); // Realiza la operación CRUD en la base de datos.

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjProfesional.ValorScalar = ObjDataBase.ValorScalar; // Asigna el valor escalar.
                }
                else // Si hay resultados en forma de tabla asigna los resultados
                {
                    ObjProfesional.DtResultados = ObjDataBase.DsResultados.Tables[0]; // Asigna los resultados
                    if (ObjProfesional.DtResultados.Rows.Count == 1) // Si hay un solo resultado
                    {
                        foreach (DataRow item in ObjProfesional.DtResultados.Rows)
                        {
                            ObjProfesional.Horario1 = item["ID_Horario"].ToString();  // Extrae el ID_Horario.
                        }
                    }
                }
            }
            else // Genera mensaje de error.
            {
                ObjProfesional.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        // Método CREATE, crea un registro en la tabla "profesional" utilizando el procedimiento almacenado.
        public void Create(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Profesional",
                NombreSP = "[SP_Profesional_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Pro", "15", ObjProfesional.Documento_Pro1);
            ObjDataBase.DtParametros.Rows.Add(@"@Horario", "15", ObjProfesional.Horario1);
            Ejecutar(ref ObjProfesional);
        }
        // Método UPDATE, actualiza un registro en la tabla "profesional" utilizando el procedimiento almacenado.
        public void Update(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Profesional",
                NombreSP = "[SP_Profesional_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Pro", "15", ObjProfesional.Documento_Pro1);
            ObjDataBase.DtParametros.Rows.Add(@"@Horario", "15", ObjProfesional.Horario1);
           

            Ejecutar(ref ObjProfesional);
        }
        // Método DELETE, elimina un registro en la tabla "profesional" utilizando el procedimiento almacenado.
        public void Delete(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Profesional",
                NombreSP = "[SP_Profesional_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Pro", "15", ObjProfesional.Documento_Pro1);
            Ejecutar(ref ObjProfesional);
        }
        // Método READ, lee un registro en la tabla "profesional" utilizando el procedimiento almacenado.
        public void Read(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Profesional",
                NombreSP = "[Sp_Profesional_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Pro", "15", ObjProfesional.Documento_Pro1);

            Ejecutar(ref ObjProfesional);
        }
        #endregion

        #region MetodosEspecificos
        //Asigna un horario a un profesional usando el procedimiento almacenado `SP_Asignar_Horario`.

        public void Asignar_Horario(ref ClsProfecional ObjProfesional, string Especialidad)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Horario",
                NombreSP = "[SP_Asignar_Horario]",
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@Especialidad", "15", Especialidad);
            Ejecutar_Horario(ref ObjProfesional);
        }
        #endregion
    }
}
