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
    // holaaaaaaaaaaaaaa
    public class ClsAdministradorLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
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
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjAdministrador.ValorScalar = ObjDataBase.ValorScalar;
                }
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
            else
            {
                ObjAdministrador.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
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
