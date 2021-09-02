using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fabrizzi_TP_Integrador
{
    class RolesMetodos : Coneccion
    {

        public Boolean grabarUsuario(Rol rolNew)
        {
            try
            {
                
                //var idMax = ultimoId();

                var sel = "set dateformat dmy INSERT INTO Roles( rol_NombreDeRol , rol_Descripcion,  rol_FechaDeAlta, rol_Estado)" +
                    " VALUES ('" + rolNew.NombreRol + "','" + rolNew.DescripcionRol  +"','" + rolNew.FechaAlta + "',"+ "'Activo')";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataTable ConsultarId(string legajo)
        {
            var sqlStr = "select rol_NombreDeRol from roles, usuarios where usu_Legajo = " + legajo+ " and usu_IdRol = rol_IdRol ";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable Consultar()
        {
            var sqlStr = "select rol_NombreDeRol 'Nombre del Rol', rol_Descripcion 'Permisos' ,rol_Estado Estado, rol_FechaDeAlta 'Fecha de alta', rol_FechaDeMod 'Fecha de modificación', rol_FechaDeBaja 'Fecha de baja' from roles" ;
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable Consultar(String nombreDeRol, String Descripcion)
        {
            var sqlStr = "select rol_IdRol from roles where rol_FechaDeBaja is null and rol_NombreDeRol = '" +nombreDeRol +"'and rol_Descripcion = '"+Descripcion+"'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable Consultar2(String nombreDeRol, String Descripcion)
        {
            var sqlStr = "select rol_NombreDeRol 'Nombre de rol', rol_Descripcion Permisos , rol_Estado Estado, rol_FechaDeAlta Alta , rol_FechaDeMod 'Modificación' , rol_FechaDeBaja Baja from roles where rol_FechaDeBaja is null and rol_NombreDeRol = '" + nombreDeRol + "' and rol_Descripcion = '" + Descripcion + "'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable Consultar3(String nombreDeRol)
        {
            var sqlStr = "select rol_Descripcion from roles where rol_FechaDeBaja is null and rol_NombreDeRol = '" + nombreDeRol + "'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }


        public DataTable ConsultarPorRol(String Rol)
        {

            var sqlStr = "select rol_NombreDeRol, rol_Descripcion ,rol_Estado, rol_FechaDeAlta, rol_FechaDeMod, rol_FechaDeBaja from roles where rol_NombreDeRol = '"+ Rol + "' order by rol_Descripcion";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }


        public DataTable ConsultarRoles2()
        {
            var sqlStr = "select rol_IdRol id, rol_NombreDeRol + ' con permisos a: ' +  rol_Descripcion 'rolDesc' from roles where rol_FechaDeBaja is null and rol_NombreDeRol not like 'Admin'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }


        public DataTable ConsultarPorEstado(String Estado)
        {

            var sqlStr = "select rol_NombreDeRol, rol_Descripcion ,rol_Estado, rol_FechaDeAlta, rol_FechaDeMod, rol_FechaDeBaja from roles where rol_Estado = '" +  Estado + "' order by rol_NombreDeRol, rol_Descripcion";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarPorRolEstado(String Rol ,String Estado)
        {

            var sqlStr = "select rol_NombreDeRol, rol_Descripcion ,rol_Estado, rol_FechaDeAlta, rol_FechaDeMod, rol_FechaDeBaja from roles where rol_Estado = " + "'" + Estado + "'" + "and rol_NombreDeRol = " + "'" + Rol + "' order by rol_NombreDeRol, rol_Descripcion";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public Boolean darDeBajaRol( int IdRol)
        {
            DateTime fecha = DateTime.Now;
            try
            {
                
                var sel = "set dateformat dmy update Roles set rol_Estado = 'Inactivo', rol_FechaDeBaja =' " + fecha +"' WHERE rol_IdRol = '" + IdRol + "' and rol_FechaDeBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean ModificarRol( String descRol, int IdRol)
        {
            DateTime fecha = DateTime.Now;
            try
            {               

                var sel = "set dateformat dmy update Roles set rol_Descripcion = '" + descRol + "', rol_FechaDeMod =' " + fecha + "' WHERE rol_IdRol = '" + IdRol + "' and rol_FechaDeBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
