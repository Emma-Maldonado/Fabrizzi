using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fabrizzi_TP_Integrador
{
    class MateriasPrimasMetodos : Coneccion
    {
        public Boolean grabarMatPri(MateriaPrima MatPri)
        {
            try
            {
                //var idMax = ultimoId();

                var sel = "set dateformat dmy insert into MateriasPrimas (mpri_CodArt,mpri_Descripcion,mpri_tipo ,mpri_CUITprov)" +
                   " VALUES ( '" + MatPri.mpri_CodArt + "','" + MatPri.mpri_Descripcion + "','" + MatPri.mpri_tipo + "','" +MatPri.mpri_CUITprov+ "')";
                SqlCommand com = new SqlCommand(sel, conectar());

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ConsultarMateria(String CodArt)
        {
            var sqlStr = "select * from MateriasPrimas where mpri_CodArt = '"+ CodArt+"';";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarMateria()
        {
            var sqlStr = "select mpri_CodArt, mpri_Descripcion,mpri_tipo,mpri_Cantidad,p.pro_RazonSocial from MateriasPrimas m,Proveedores p where m.mpri_CUITprov =p.pro_CUIT ;";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public DataTable ConsultarMatPrimaporProv(String ProvRS)
        {
            var sqlStr = "select  mpri_CodArt, mpri_Descripcion,mpri_tipo,mpri_Cantidad,p.pro_RazonSocial from MateriasPrimas,Proveedores p where p.pro_RazonSocial ='"+ ProvRS + "';";
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

    }
}
