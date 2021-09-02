using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fabrizzi_TP_Integrador
{
    class UsuariosMetodos : Coneccion
    {
        public DataTable Consultar()
        {
            var sqlStr = "select usu_Legajo, usu_Nombre + ' '+ usu_Apellido,usu_DNI ,usu_Area ,usu_Estado,usu_FechaDeAlta,usu_FechaDeMod,usu_FechaDeBaja from Usuarios ";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public Boolean grabarUsuario(Usuario usu)
        {
           
            try
            {
                //var idMax = ultimoId();

                var sel = "set dateformat dmy INSERT INTO Usuarios(usu_Nombre , usu_Apellido, usu_DNI, usu_FechaDeAlta , usu_IdRol , usu_Estado, usu_Contrasenia, usu_Area)" +
                    " VALUES ( '"+ usu.Nombre + "','" + usu.Apellido + "','" + usu.DNI + "','" + usu.FechaDeAlta + "', '" + usu.IdRol + "', 'Activo', 1234 ,'"+ usu.Area +"')";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataTable ConsultarDni(String DNI)
        {
            var sqlStr = "select usu_DNI from Usuarios where usu_DNI = '"+ DNI + "' and usu_Estado = 'Activo'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable ConsultarPorRol(String Rol)
        {
            var sqlStr = "select usu_Legajo  , usu_Nombre + ' '+ usu_Apellido, usu_DNI , usu_Area , usu_Estado, usu_FechaDeAlta , usu_FechaDeMod, usu_FechaDeBaja from Usuarios u  , roles r where rol_NombreDeRol = '"+ Rol + "' and u.usu_IdRol = r.rol_IdRol and rol_NombreDeRol not like 'Admin'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable ConsultarPorArea(String Area)
        {
            var sqlStr = "select usu_Legajo  , usu_Nombre + ' '+ usu_Apellido, usu_DNI , usu_Area , rol_NombreDeRol, usu_Estado, usu_FechaDeAlta , usu_FechaDeMod, usu_FechaDeBaja from Usuarios , Roles where usu_Area = '" + Area+ "' and usu_IdRol = rol_IdRol";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable ConsultarPorAreaRol(String Area, String Rol)
        {
            var sqlStr = "select usu_Legajo  , usu_Nombre + ' '+ usu_Apellido, usu_DNI , usu_Area , rol_NombreDeRol, usu_Estado, usu_FechaDeAlta , usu_FechaDeMod, usu_FechaDeBaja from Usuarios , Roles where usu_Area = '" +Area +"' and usu_IdRol = rol_IdRol and rol_NombreDeRol = '" +Rol +"'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public Boolean ModificarRol(int Rol, int Legajo)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = "set dateformat dmy update Usuarios set usu_IdRol =  '" + Rol + "', usu_FechaDeMod =' " + fecha + "' WHERE usu_Legajo = '" + Legajo + "' and usu_FechaDeBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean ModificarArea(String Area, int Legajo)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = "set dateformat dmy update Usuarios set usu_Area ='" + Area + "', usu_FechaDeMod =' " + fecha + "' WHERE usu_Legajo='" + Legajo + "' and usu_FechaDeBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean ModificarAreaRol(int Rol, int Legajo, String Area)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = "set dateformat dmy update Usuarios set usu_IdRol =  '" + Rol + "',usu_Area = '" + Area + "', usu_FechaDeMod =' " + fecha + "' WHERE usu_Legajo = '" + Legajo + "' and usu_FechaDeBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ConsultarLegajo2(int Legajo)
        {
            var sqlStr = "  select usu_Legajo, usu_Nombre + ' '+ usu_Apellido,usu_DNI ,usu_Area ,usu_Estado,usu_FechaDeAlta,usu_FechaDeMod,usu_FechaDeBaja from Usuarios where usu_Legajo = '" + Legajo + "'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public DataTable ConsultarLegajo(int Legajo)
        {
            var sqlStr = "select usu_Legajo from Usuarios where usu_Legajo = '" + Legajo + "'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public Boolean darDeBajaUsuario(int legajo)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = " set dateformat dmy update Usuarios set usu_Estado = 'Inactivo', usu_FechaDeBaja = '" + fecha + "' WHERE usu_Legajo = '" + legajo + "' and usu_FechaDeBaja is null";
                ;
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
