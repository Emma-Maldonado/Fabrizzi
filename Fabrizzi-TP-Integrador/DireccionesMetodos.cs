using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fabrizzi_TP_Integrador
{
    class DireccionesMetodos : Coneccion
    {
        public Boolean grabarDireccion(Direccion dir)
        {
            try
            {
                //var idMax = ultimoId();

                var sel = "set dateformat dmy insert into Direcciones (dir_IdDir, dir_Calle,dir_Numero ,dir_Piso ,dir_Departamento, dir_Local , dir_Localidad,dir_Provincia, dir_CP) " +
                   " VALUES ( '" + dir.dir_IdDir + "','" + dir.dir_Calle + "','" + dir.dir_Numero + "','" + dir.dir_Piso + "', '" + dir.dir_Departamento + "', '" +dir.dir_Local+ "','" + dir.dir_Localidad + "', '" + dir.dir_Provincia + "','" +dir.dir_CP +"')";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataTable ConsultarIdDirProv()
        {
            var sqlStr = "select top 1 substring(dir_IdDir, CHARINDEX('-', dir_IdDir)+1, len(dir_IdDir)-(CHARINDEX('-', dir_IdDir)-1)) from Direcciones where dir_IdDir like 'P-%'  order by dir_IdDir desc";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarDirProv()
        {
            var sqlStr = "select top 1 dir_IdDir from Direcciones order by dir_IdDir desc;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarDirLocal()
        {
            var sqlStr = "select top 1 dir_Calle Calle, dir_Numero Numero, dir_Piso Piso, dir_Departamento Dpto, dir_Local 'Local N°', dir_Localidad Localidad, dir_Provincia Provincia, dir_CP CP from Direcciones where dir_IdDir like 'L-%' order by dir_IdDir desc";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }
        public DataTable ConsultarLocal()
        {
            var sqlStr = "select top 1 dir_IdDir from Direcciones where dir_IdDir like 'L-%' order by dir_IdDir desc;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarProv()
        {
            var sqlStr = "select top 1 dir_Calle Calle, dir_Numero Numero, dir_Piso Piso, dir_Departamento Dpto, dir_Local 'Local N°', dir_Localidad Localidad, dir_Provincia Provincia, dir_CP CP from Direcciones where dir_IdDir like 'P-%' order by dir_IdDir desc";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }



        public DataTable ConsultarIdDirLoc()
        {
            var sqlStr = "select top 1 substring(dir_IdDir, CHARINDEX('-', dir_IdDir)+1, len(dir_IdDir)-(CHARINDEX('-', dir_IdDir)-1)) from Direcciones where dir_IdDir like 'L-%'  order by dir_IdDir desc";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarDireccion(String idDir)
        {
            var sqlStr = "select  dir_Calle , dir_Numero, dir_Piso , dir_Departamento, dir_Local, dir_Localidad , dir_Provincia , dir_CP from Direcciones where dir_IdDir ='"+idDir+"' ";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public Boolean BorrarDireccion(String dir)
        {
            try
            {
                //var idMax = ultimoId();

                var sel = "delete from Direcciones where dir_IdDir = '"+ dir+"'";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public Boolean ModificarDireccion(Direccion dir)
        {
            try
            {
                //var idMax = ultimoId();

                var sel = "set dateformat dmy update Direcciones set dir_Calle = '" + dir.dir_Calle+"',dir_Numero= "+dir.dir_Numero+" ,dir_Piso = "+dir.dir_Piso+" ,dir_Departamento = '"+dir.dir_Departamento+"', dir_Local = '"+dir.dir_Local+"', dir_Localidad ='"+dir.dir_Localidad+"' ,dir_Provincia = '"+dir.dir_Provincia+"', dir_CP = "+dir.dir_CP+" where dir_IdDir = '"+dir.dir_IdDir+"'";
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
