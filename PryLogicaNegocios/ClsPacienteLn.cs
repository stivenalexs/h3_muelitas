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
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Paciente" mediante el procedimiento almacenado.
        // El objeto ClsPaciente se pasa por referencia y será actualizado con los datos obtenidos.
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
            // Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados.
            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar) // Si el resultado es un valor escalar, este lo va a asignar a Paciente.
                {
                    ObjPaciente.ValorScalar = ObjDataBase.ValorScalar;
                }
                else // Si es una tabla de datos, la asigna a horario y extrae los valores
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
            else // Genera mensaje de error.
            {
                ObjPaciente.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        // Método CREATE, crea un registro en la tabla "Paciente" utilizando el procedimiento almacenado.
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
        // Método UPDATE, actualiza un registro en la tabla "Paciente" utilizando el procedimiento almacenado.
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
        // Método DELETE, elimina un registro en la tabla "Paciente" utilizando el procedimiento almacenado.
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
        // Método READ, lee un registro en la tabla "Paciente" utilizando el procedimiento almacenado.
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
