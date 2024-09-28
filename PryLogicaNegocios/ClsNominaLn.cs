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
    public class ClsNominaLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        // Método que configura la consulta a la base de datos para obtener información
        // De la tabla "Nomina" mediante el procedimiento almacenado.
        // El objeto ClNomina se pasa por referencia y será actualizado con los datos obtenidos.
        public void Index(ref ClsNomina ObjNomina)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Nomina",
                NombreSP = "[SP_Nomina_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjNomina);
        }

        #endregion

        private void Ejecutar(ref ClsNomina ObjNomina)
        {
            // Ejecuta la operación CRUD en la base de datos, pasando por el objeto ObjDatabase como referencia.
            ObjDataBase.CRUD(ref ObjDataBase);

            // En caso de no haber errores, comienza a procesar los resultados.
            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar) // Si el resultado es un valor escalar, este lo va a asignar a la Nómima.
                {
                    ObjNomina.ValorScalar = ObjDataBase.ValorScalar;
                }
                else // Si es una tabla de datos, la asigna a horario y extrae los valores
                {
                    ObjNomina.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjNomina.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjNomina.DtResultados.Rows)
                        {
                            ObjNomina.ID_Nomina1 = item["ID_Nomina"].ToString();
                            ObjNomina.Doc_Profesional1 = ObjNomina.ID_Nomina1 = item["Doc_Pro"].ToString();
                            ObjNomina.Salario1 = Convert.ToDouble(item["Salario"].ToString());
                            ObjNomina.Fecha_Pago1 = Convert.ToDateTime(item["Fecha_Pago"].ToString());
                            ObjNomina.Estado1 = item["Estado"].ToString();


                        }
                    }
                }
            }
            else // Se genera el mensaje de error
            {
                ObjNomina.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        // Método CREATE, crea un registro en la tabla "Nomina" utilizando el procedimiento almacenado.
        public void Create(ref ClsNomina ObjNomina)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Nomina",
                NombreSP = "[SP_Nomina_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Nomina", "15", ObjNomina.ID_Nomina1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Pro", "15", ObjNomina.Doc_Profesional1);
            ObjDataBase.DtParametros.Rows.Add(@"@Salario", "6", ObjNomina.Salario1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Pago", "11", ObjNomina.Fecha_Pago1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "15", ObjNomina.Estado1);

            Ejecutar(ref ObjNomina);
        }
        // Método UPDATE, actualiza un registro en la tabla "Nomina" utilizando el procedimiento almacenado.
        public void Update(ref ClsNomina ObjNomina)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Nomina",
                NombreSP = "[SP_Nomina_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Nomina", "15", ObjNomina.ID_Nomina1);
            ObjDataBase.DtParametros.Rows.Add(@"@Doc_Pro", "15", ObjNomina.Doc_Profesional1);
            ObjDataBase.DtParametros.Rows.Add(@"@Salario", "6", ObjNomina.Salario1);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Pago", "11", ObjNomina.Fecha_Pago1);
            ObjDataBase.DtParametros.Rows.Add(@"@Estado", "15", ObjNomina.Estado1);

            Ejecutar(ref ObjNomina);
        }
        // Método DELETE, elimina un registro en la tabla "Nomina" utilizando el procedimiento almacenado.
        public void Delete(ref ClsNomina ObjNomina)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Nomina",
                NombreSP = "[SP_Nomina_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Nomina", "15", ObjNomina.ID_Nomina1);
            Ejecutar(ref ObjNomina);
        }
        // Método READ, lee un registro en la tabla "Nomina" utilizando el procedimiento almacenado.
        public void Read(ref ClsNomina ObjNomina)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Nomina",
                NombreSP = "[SP_Nomina_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Nomina", "15", ObjNomina.ID_Nomina1);

            Ejecutar(ref ObjNomina);
        }
        #endregion
    }
}
