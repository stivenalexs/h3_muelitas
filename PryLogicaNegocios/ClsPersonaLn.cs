﻿using PryAccesoDatos;
using PryEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryLogicaNegocio
{
    public class ClsPersonaLn
    {
        #region VariablePrivada
        private ClsAccesoDatos ObjDataBase = null;
        #endregion

        #region MetodoIndex
        public void Index(ref ClsPersona ObjPersona)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Persona",
                NombreSP = "[SP_Persona_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjPersona);
        }

        #endregion

        private void Ejecutar(ref ClsPersona ObjPersona)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorOS == null) //No hay error
            {
                if (ObjDataBase.Scalar)
                {
                    ObjPersona.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjPersona.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjPersona.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjPersona.DtResultados.Rows)
                        {
                            ObjPersona.ID_Persona1 = item["ID_Persona"].ToString();
                            ObjPersona.Foto = item["Foto"].ToString();
                            ObjPersona.Numero_contacto = item["Telefono"].ToString();
                            ObjPersona.Numero_documento = item["Documento"].ToString();
                            ObjPersona.Fecha_N1 = Convert.ToDateTime(item["Fecha_Nacimiento"].ToString());
                            ObjPersona.Correo_electronico = item["Correo"].ToString();
                            ObjPersona.Nombre = item["Nombre"].ToString();
                            ObjPersona.TipoSangre = item["Tipo_sangre"].ToString() ;
                            ObjPersona.Contraseña = item["Contraseña"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjPersona.MensajeError = ObjDataBase.MensajeErrorOS;
            }
        }

        #region  MetodosCrud
        public void Create(ref ClsPersona ObjPersona)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Persona",
                NombreSP = "[SP_Persona_Create]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Persona", "15", ObjPersona.ID_Persona1);
            ObjDataBase.DtParametros.Rows.Add(@"@Documento", "15", ObjPersona.Numero_documento);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "15", ObjPersona.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Nacimiento", "13", ObjPersona.Fecha_N1);
            ObjDataBase.DtParametros.Rows.Add(@"@Telefono", "15", ObjPersona.Numero_contacto);
            ObjDataBase.DtParametros.Rows.Add(@"@Correo", "15", ObjPersona.Correo_electronico);
            ObjDataBase.DtParametros.Rows.Add(@"@Contraseña", "15", ObjPersona.Contraseña);
            ObjDataBase.DtParametros.Rows.Add(@"@foto", "15", ObjPersona.Foto);
            ObjDataBase.DtParametros.Rows.Add(@"@Tipo_Sangre", "15", ObjPersona.TipoSangre);
            Ejecutar(ref ObjPersona);
        }

        public void Update(ref ClsPersona ObjPersona)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Persona",
                NombreSP = "[SP_Persona_Update]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Persona", "15", ObjPersona.ID_Persona1);
            ObjDataBase.DtParametros.Rows.Add(@"@Documento", "15", ObjPersona.Numero_documento);
            ObjDataBase.DtParametros.Rows.Add(@"@Nombre", "15", ObjPersona.Nombre);
            ObjDataBase.DtParametros.Rows.Add(@"@Fecha_Nacimiento", "13", ObjPersona.Fecha_N1);
            ObjDataBase.DtParametros.Rows.Add(@"@Telefono", "15", ObjPersona.Numero_contacto);
            ObjDataBase.DtParametros.Rows.Add(@"@Correo", "15", ObjPersona.Correo_electronico);
            ObjDataBase.DtParametros.Rows.Add(@"@Contraseña", "15", ObjPersona.Contraseña);
            ObjDataBase.DtParametros.Rows.Add(@"@foto", "15", ObjPersona.Foto);
            ObjDataBase.DtParametros.Rows.Add(@"@Tipo_Sangre", "15", ObjPersona.TipoSangre);


            Ejecutar(ref ObjPersona);
        }

        public void Delete(ref ClsPersona ObjPersona)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Persona",
                NombreSP = "[SP_Persona_Delete]",
                Scalar = true

            };
            ObjDataBase.DtParametros.Rows.Add(@"ID_Persona", "15", ObjPersona.ID_Persona1);
            Ejecutar(ref ObjPersona);
        }

        public void Read(ref ClsPersona ObjPersona)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Persona",
                NombreSP = "[Sp_Persona_Read]",
                Scalar = false

            };
            ObjDataBase.DtParametros.Rows.Add(@"@ID_Persona", "15", ObjPersona.ID_Persona1);

            Ejecutar(ref ObjPersona);
        }
        #endregion

        #region MetodosEspecifico
        public void Validar(ref ClsPersona ObjPersona)
        {
            ObjDataBase = new ClsAccesoDatos()
            {
                NombreTabla = "Persona",
                NombreSP = "[SP_Iniciar_Sesion]",
                Scalar = false,
            };
            ObjDataBase.DtParametros.Rows.Add(@"@Correo", "15", ObjPersona.Correo_electronico);
            ObjDataBase.DtParametros.Rows.Add(@"@Contraseña", "15", ObjPersona.Contraseña);
            Ejecutar(ref ObjPersona);
        }
        #endregion
    }
}
