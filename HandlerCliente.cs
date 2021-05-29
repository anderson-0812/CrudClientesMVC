using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CONTROLGAMES.DAC.DAT
{
    public class HandlerCliente
    {
        public HandlerCliente()
        {
            ConectionBD.abrirConexion();
        }

        public void Insert_Cliente(string ruc, string nom,string dir,string tel,string ciu)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@CLI_RUC", SqlDbType.VarChar, 13);
                param[0].Value = ruc;
                param[1] = new SqlParameter("@CLI_NOM", SqlDbType.VarChar, 40);
                param[1].Value = nom;
                param[2] = new SqlParameter("@CLI_DIR", SqlDbType.VarChar, 40);
                param[2].Value = dir;
                param[3] = new SqlParameter("@CLI_TEL", SqlDbType.VarChar, 9);
                param[3].Value = tel;
                param[4] = new SqlParameter("@CLI_CIU", SqlDbType.VarChar, 20);
                param[4].Value = ciu;

                SqlHelper.ExecuteNonQuery(ConectionBD.sqlConn, CommandType.StoredProcedure, "INSERT_CLIENTE", param);
                ConectionBD.cerrarConexion();
            }
            catch (Exception e) { throw (e); }
        }

        public DataSet Select_Cliente_x_Ruc(string ruc)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CLI_RUC", SqlDbType.VarChar,13);
                param[0].Value = ruc;

                ds = SqlHelper.ExecuteDataset(ConectionBD.sqlConn, CommandType.StoredProcedure, "SELECT_CLIENTE_X_RUC", param);
                ConectionBD.cerrarConexion();
                return ds;
            }
            catch (Exception e) { throw (e); }
        }

        public DataSet Select_Cliente_x_Letras(string ruc)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CADENA", SqlDbType.VarChar, 13);
                param[0].Value = ruc;

                ds = SqlHelper.ExecuteDataset(ConectionBD.sqlConn, CommandType.StoredProcedure, "SELECT_CLIENTE_X_LETRAS", param);
                ConectionBD.cerrarConexion();
                return ds;
            }
            catch (Exception e) { throw (e); }
        }

        public DataSet Select_Cliente_x_Nombre_Letras(string nombre)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CADENA", SqlDbType.VarChar, 13);
                param[0].Value = nombre;

                ds = SqlHelper.ExecuteDataset(ConectionBD.sqlConn, CommandType.StoredProcedure, "SELECT_CLIENTE_X_NOMBRE_LETRAS", param);
                ConectionBD.cerrarConexion();
                return ds;
            }
            catch (Exception e) { throw (e); }
        }

        public DataSet Select_Cliente_x_Sec(int sec)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CLI_SEC", SqlDbType.Int);
                param[0].Value = sec;

                ds = SqlHelper.ExecuteDataset(ConectionBD.sqlConn, CommandType.StoredProcedure, "SELECT_CLIENTE_X_SEC", param);
                ConectionBD.cerrarConexion();
                return ds;
            }
            catch (Exception e) { throw (e); }
        }

        public void update_cliente_x_ruc(string ruc,string nombre,string dir,string tel,string ciu)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@CLI_RUC", SqlDbType.VarChar, 13);
                param[0].Value = ruc;
                param[1] = new SqlParameter("@CLI_NOM", SqlDbType.VarChar, 40);
                param[1].Value = nombre;
                param[2] = new SqlParameter("@CLI_DIR", SqlDbType.VarChar, 40);
                param[2].Value = dir;
                param[3] = new SqlParameter("@CLI_TEL", SqlDbType.VarChar, 9);
                param[3].Value = tel;
                param[4] = new SqlParameter("@CLI_CIU", SqlDbType.VarChar, 20);
                param[4].Value = ciu;
                SqlHelper.ExecuteNonQuery(ConectionBD.sqlConn, CommandType.StoredProcedure, "UPDATE_CLIENTE_X_RUC", param);
            }
            catch (Exception e) { throw (e); }
        }

        public void delete_cliente_x_ruc(string ruc)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CLI_RUC", SqlDbType.VarChar, 13);
                param[0].Value = ruc;
                SqlHelper.ExecuteNonQuery(ConectionBD.sqlConn, CommandType.StoredProcedure, "DELETE_CLIENTE_X_RUC", param);
            }
            catch (Exception e) { throw (e); }
        }

        public DataSet Select_All_Cliente()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(ConectionBD.sqlConn, CommandType.StoredProcedure, "SELECT_ALL_CLIENTE");
                ConectionBD.cerrarConexion();
                return ds;
            }
            catch (Exception e) { throw (e); }
        }
    }
}
