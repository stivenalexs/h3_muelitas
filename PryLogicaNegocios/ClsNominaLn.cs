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
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjNomina.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
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
            else
            {
                ObjNomina.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
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
