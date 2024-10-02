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

        #region metodos ejecutar
        private void Ejecutar(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjProfesional.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjProfesional.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjProfesional.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjProfesional.DtResultados.Rows)
                        {
                            ObjProfesional.Horario1 = item["Horario"].ToString();
                            ObjProfesional.Documento_Pro1 = item["Doc_Pro"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjProfesional.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        private void Ejecutar_Horario(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjProfesional.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjProfesional.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjProfesional.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjProfesional.DtResultados.Rows)
                        {
                            ObjProfesional.Horario1 = item["ID_Horario"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjProfesional.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        private void Ejecutar_U(ref ClsProfecional ObjProfesional)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjProfesional.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjProfesional.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjProfesional.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjProfesional.DtResultados.Rows)
                        {
                            
                        }
                    }
                }
            }
            else
            {
                ObjProfesional.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #endregion

        #region  MetodosCrud
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
        public void buscar_profesionales(ref ClsProfecional ObjProfesional, string tipo_cita)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Persona",
                NombreSP = "[SP_Buscar_Profesional]",
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@Especialidad", "15", tipo_cita);
            Ejecutar_U(ref ObjProfesional);
        }
        public void llenar_Por_Nombre(ref ClsProfecional ObjProfesional, string Nombre)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Profesional",
                NombreSP = "[SP_Buscar_DocPro]",
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "15", Nombre);
            Ejecutar(ref ObjProfesional);
        }

        #endregion
    }
}
