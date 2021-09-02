using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fabrizzi_TP_Integrador
{
    class LocalesMetodos : Coneccion
    {
        public Boolean grabarLocal(Local loc)
        {
            DateTime fecha = DateTime.Now;
            try
            {
                //var idMax = ultimoId();

                var sel = "set dateformat dmy insert into Locales((loc_Nombre,loc_Outlet,loc_IdDir, loc_Telefono, loc_Email, loc_Fabrica , loc_FechaAlta ) " +
                   " VALUES ( '" + loc.Nombre + "','" + loc.Oulet + "','" + loc.Direccion + "','" +loc.Telefono+ "','" + loc.Email +"','" + loc.Fabrica+"','" + fecha + "')";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ConsultarLocales()
        {
            var sqlStr = "select loc_Nombre 'Nombre del local', dir_Calle + ' '+ CONVERT(varchar(10), dir_Numero )+ ', '+ dir_Localidad + ', '+ dir_Provincia Domicilio,loc_Telefono Telefono, loc_Email 'E-mail', loc_Fabrica 'Es fábrica?',loc_Outlet 'Es outlet?',loc_FechaAlta 'Fecha de alta',loc_FechaModificacion 'Fecha de modificacion', loc_FechaBaja 'Fecha de baja'  from Locales loc , Direcciones where loc_IdDir = dir_IdDir";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
        
        public DataTable ConsultarLocalId(int IdLoc)
        {
            var sqlStr = "select loc_IdLoc, dir.dir_Calle,dir.dir_Numero,dir.dir_Provincia,dir_Localidad from Locales,loc_FechaAlta,loc_FechaBaja Direcciones  dir where loc_IdLoc = '" + IdLoc + "' and loc_IdDir = dir.dir_IdDir";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarPorNombre(String NombreLocal)
        {
            var sqlStr = "select loc_Nombre 'Nombre del local', dir_Calle + ' '+ CONVERT(varchar(10), dir_Numero )+ ', '+ dir_Localidad + ', '+ dir_Provincia Domicilio,loc_Telefono Telefono, loc_Email 'E-mail', loc_Fabrica 'Es fábrica?',loc_Outlet 'Es outlet?',loc_FechaAlta 'Fecha de alta',loc_FechaModificacion 'Fecha de modificacion',loc_FechaBaja 'Fecha de baja' from Locales loc , Direcciones where loc_IdDir = dir_IdDir and loc.loc_Nombre like '%" + NombreLocal + "%'; ";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }


        public Boolean darDeBajaProveedor(int IdLocal)
        {
            DateTime fecha = DateTime.Now;
            try
            {

                var sel = "set dateformat dmy update Locales set  loc_FechaBaja =' " + fecha + "' WHERE loc_IdLoc = '" + IdLocal + "' and loc_FechaBaja is null";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //set dateformat dmy update Locales set  loc_FechaBaja =' " + fecha + "' WHERE loc_IdLoc = '" + IdLocal + "' and loc_FechaBaja is null"
    }
}
