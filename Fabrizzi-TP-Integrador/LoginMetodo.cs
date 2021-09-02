using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Fabrizzi_TP_Integrador
{
    class LoginMetodo : Coneccion
    {
        public DataTable ConsultarLogin(string usu, string pas)
        {
            string sqlStr = "select usu_Legajo, usu_Contrasenia from Usuarios where usu_Legajo = '" + usu + "' and usu_Contrasenia = '" +
                            pas + "'";

            //var c = AbrirConexion();


            //********************************************************
            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
            //*****************************************************
        }
        public int ultimoId()
        {
            var selMax = "select max(id) + 1 from Login";
            //********************************************************
            SqlCommand com = new SqlCommand(selMax, conectar());
            return (int)com.ExecuteScalar();
        }

        public DataTable  consultaNombre (string usu)
        {

            string sqlStr2 = "select usu_Nombre +' '+ usu_Apellido from Usuarios where usu_Legajo = '" + usu + "'";
            
            var dap = new SqlDataAdapter(sqlStr2, conectar());
            var da = new DataTable();
            dap.Fill(da);
            DataTable dt = da;
            return dt;
        }

        //public Boolean grabarUsuario(LoginEn usu)
        //{
        //    try
        //    {
        //        var idMax = ultimoId();

        //        var sel = "set dateformat dmy INSERT INTO Login(id,Usuario, Contrasenia, Permisos)" +
        //            " VALUES (" + idMax + ",'" + usu.usuario + "','" + usu.contrasenia + "'," + usu.permisos + ")";
        //        SqlCommand com = new SqlCommand(sel, conectar());

        //        com.ExecuteNonQuery();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        }
    }

