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
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjOrden.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
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
            else
            {
                ObjOrden.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }
        #endregion

        #region  MetodosCrud
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
