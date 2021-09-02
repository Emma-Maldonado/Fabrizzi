using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;//Ultimo erika

namespace Fabrizzi_TP_Integrador
{
    class ProveedoresMetodos : Coneccion
    {
        public Boolean grabarProveedor(Proveedor prov)
        {
            DateTime fecha = DateTime.Now;
            try
            {
                //var idMax = ultimoId();

                var sel = "set dateformat dmy insert into Proveedores (pro_CUIT ,pro_RazonSocial , pro_IdDireccion, pro_Telefono , pro_Email, pro_FechaAlta) " +
                   " VALUES ( '" + prov.pro_CUIT + "','" + prov.pro_RazonSocial + "','" + prov.pro_IdDireccion + "','" + prov.pro_Telefono + "', '" + prov.pro_Email + "','"+ fecha +"')";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataTable ConsultarProv(String Cuit)
        {
            var sqlStr = "select pro_CUIT from Proveedores where pro_CUIT = '"+Cuit+" ';";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarProv()
        {
            var sqlStr = "select pro_CUIT CUIT, pro_RazonSocial 'Razón Social', pro_Telefono Telefono, pro_Email 'E-mail' , dir_Calle + ' '+ CONVERT(varchar(10), dir_Numero )+ ', '+ dir_Localidad + ', '+ dir_Provincia Domicilio,pro_FechaAlta ,pro_FechaBaja from  Proveedores , Direcciones where pro_IdDireccion = dir_IdDir;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarProv2(String CUIT)
        {
            var sqlStr = "select pro_CUIT, pro_RazonSocial, pro_Telefono, pro_Email , dir_Calle + ' '+ CONVERT(varchar(10), dir_Numero )+ ', '+ dir_Localidad + ', '+ dir_Provincia Domicilio, pro_FechaAlta,pro_FechaBaja  from Proveedores , Direcciones where pro_IdDireccion = dir_IdDir and pro_CUIT = '" + CUIT+"';";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarProv2(String CUIT, String RazoSocial)
        {
            var sqlStr = "select pro_CUIT, pro_RazonSocial, pro_Telefono, pro_Email , dir_Calle + ' '+ CONVERT(varchar(10), dir_Numero )+ ', '+ dir_Localidad + ', '+ dir_Provincia ,pro_FechaAlta ,pro_FechaBaja Domicilio from Proveedores , Direcciones , pro_FechaAlta,pro_FechaBaja   where pro_IdDireccion = dir_IdDir and pro_CUIT = '" + CUIT+"' and pro_RazonSocial like '%"+RazoSocial+"%' ;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarProv3(String RazoSocial)
        {
            var sqlStr = "select pro_CUIT, pro_RazonSocial, pro_Telefono, pro_Email , dir_Calle + ' '+ CONVERT(varchar(10), dir_Numero )+ ', '+ dir_Localidad + ', '+ dir_Provincia Domicilio, pro_FechaAlta 'Fecha de alta' ,pro_FechaBaja 'Fecha de baja' from Proveedores , Direcciones where pro_IdDireccion = dir_IdDir and pro_RazonSocial like '%" + RazoSocial + "%' ;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarIdDirProv(String CUIT)
        {
            var sqlStr = "select pro_IdDireccion from Proveedores where pro_CUIT = '"+CUIT+"'";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public Boolean ModificarTelProv(String CUIT, String Tel)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = "set dateformat dmy update Proveedores set pro_Telefono = '" + Tel + "',pro_FechaModificacion = '" + fecha + "' where pro_CUIT = '" + CUIT + "' and pro_FechaBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean ModificarMailProv(String CUIT, String Mail)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = "set dateformat dmy update Proveedores set pro_Email = '" + Mail + "',pro_FechaModificacion = '"+ fecha +"' where pro_CUIT = '" + CUIT + "' and pro_FechaBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean darDeBajaProveedor(String CUIT)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = "set dateformat dmy update Proveedores set  pro_FechaBaja =' " + fecha + "' WHERE pro_CUIT = '" + CUIT + "' and pro_FechaBaja is null";
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
