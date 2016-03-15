using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BusinessEntity;
using FirebirdSql.Data.FirebirdClient;

namespace DataLayer
{
    public class dbHelper
    {
        private FbConnectionStringBuilder cb = null;
        private FbConnection conexion;
        private bool inmediateClose = true;

        public bool InmediateClose
        {
            get { return inmediateClose; }
            set { inmediateClose = value; }
        }

        public dbHelper()
        {
            if (cb == null)
            {

                cb = new FbConnectionStringBuilder();
                cb.UserID = "SYSDBA";
                cb.Password = "masterkey";
                cb.ClientLibrary = "fbembed.dll";
                cb.Database = System.IO.File.ReadAllText("database.txt");
                //cb.Database = ConfigurationManager.ConnectionStrings["BaseDatosRegistrales"].ConnectionString;
                //System.IO.FileInfo info = new System.IO.FileInfo(1TarjetaAdmin.AppDesktop.Properties.Settings.Default.PATH_BD);
                cb.ServerType = FbServerType.Embedded;
            }
        }

        private void openConexion()
        {
            if (conexion == null)
            {
                conexion = new FbConnection(cb.ConnectionString);
                conexion.Open();
            }
            
        }

        public void closeConexion()
        {
            if (conexion != null && inmediateClose)
                conexion.Close();
        }

        public void forceCloseConnection()
        {
            if (conexion != null)
                conexion.Close();
        }

        public void insertValues(string values, string keys)
        {
            FbCommand fbcommand;

            try
            {
                openConexion();
                fbcommand = new FbCommand("INSERT INTO T_PERSONASPROSPECTOS (" + keys + ") VALUES (" + values + ")", conexion);
                fbcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                closeConexion();
            }
        }

        public string valueForKey(string key, string tabla)
        {
            try
            {
                openConexion();

                return Convert.ToString(new FbCommand("Select " + key + " From " + tabla, conexion));
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                closeConexion();
            }
        }

        public int getNextId<T>(ManagerEntity<T> managerEntity)
        {
            FbCommand comm;
            int lastId;
            try
            {
                openConexion();
                comm = new FbCommand(managerEntity.sqlSelectMaxId(), conexion);
                lastId = (int)comm.ExecuteScalar();
            }
            catch
            {
                lastId = 0;
            }
            finally
            {
                closeConexion();
            }
            return lastId + 1;
        }

        public void insert<T>(ManagerEntity<T> managerEntity)
        {
            FbCommand comm;

            try
            {
                openConexion();
                comm = new FbCommand(managerEntity.sqlInsert, conexion);

                foreach (string key in managerEntity.paramsQuery.Keys)
                {
                    if (managerEntity.sqlInsert.Contains("@" + key))
                    {
                        comm.Parameters.AddWithValue("@" + key, managerEntity.paramsQuery[key] == null ? DBNull.Value : managerEntity.paramsQuery[key]);
                    }
                }

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConexion();
            }
        }

        private FbTransaction transaction = null;

        public int insertReturnId<T>(ManagerEntity<T> managerEntity)
        {
            FbCommand comm;
            
            
            try
            {                
                openConexion();
                transaction = conexion.BeginTransaction();
                comm = new FbCommand(managerEntity.sqlInsert, conexion,transaction);

                foreach (string key in managerEntity.paramsQuery.Keys)
                {
                    if (managerEntity.sqlInsert.Contains("@" + key))
                    {
                        comm.Parameters.AddWithValue("@" + key, managerEntity.paramsQuery[key] == null ? DBNull.Value : managerEntity.paramsQuery[key]);
                    }
                }

                comm.ExecuteNonQuery();

                int id = int.Parse(this.query(managerEntity.sqlSelectMaxId(),null).Rows[0][0].ToString());
                transaction.Commit();
                return id;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                throw ex;
            }
            finally
            {
                
                closeConexion();
            }
        }

        public int getLastId(string tabla)
        {
            try
            {
                openConexion();
                
                return int.Parse(new FbCommand("Select count(*) From " + tabla, conexion).ExecuteScalar().ToString()) + 1;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                closeConexion();
            }
        }

        public  DataTable query(string sql, Dictionary<string, object> param)
        {
            FbCommand comm;
            FbDataAdapter adapter;
            DataTable table;

            try
            {
                openConexion();
                if(transaction != null)
                    comm = new FbCommand(sql, conexion,transaction);
                else
                    comm = new FbCommand(sql, conexion);

                if (param != null)
                {
                    foreach (string key in param.Keys)
                    {
                        try
                        {
                            if (sql.Contains("@" + key))
                            {
                                comm.Parameters.AddWithValue("@" + key, param[key] == null ? DBNull.Value : param[key]);
                            }
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message + " Key: " + key);
                        }
                    }
                }

                adapter = new FbDataAdapter(comm);
                table = new DataTable();
                adapter.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(transaction == null)
                    closeConexion();
            }
        }

        public void update(string sql, Dictionary<string, object> param)
        {
            FbCommand comm;
            
            try
            {
                openConexion();

                comm = new FbCommand(sql, conexion);

                if (param != null)
                {
                    foreach (string key in param.Keys)
                    {
                        if (sql.Contains("@" + key))
                        {
                            comm.Parameters.AddWithValue("@" + key, param[key] == null ? DBNull.Value : param[key]);
                        }
                    }
                }

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConexion();
            }
        }

        public DataTable get<T>(ManagerEntity<T> manager)
        {
            FbCommand comm;
            FbDataAdapter adapter;
            DataTable table;

            try
            {
                openConexion();
                comm = new FbCommand(manager.sqlGet, conexion);

                if (manager.paramsQuery != null)
                {
                    foreach (string key in manager.paramsQuery.Keys)
                    {
                        if (manager.sqlGet.Contains("@" + key))
                        {
                            comm.Parameters.AddWithValue("@" + key, manager.paramsQuery[key] == null ? DBNull.Value : manager.paramsQuery[key]);
                        }
                    }
                }

                adapter = new FbDataAdapter(comm);
                table = new DataTable();
                adapter.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConexion();
            }
        }

        public void delete<T>(ManagerEntity<T> managerEntity)
        {
            FbCommand comm;
            
            try
            {
                openConexion();
                comm = new FbCommand(managerEntity.sqlDelete, conexion);
                
                foreach (string key in managerEntity.paramsQuery.Keys)
                {
                    if (managerEntity.sqlDelete.Contains("@" + key))
                    {
                        comm.Parameters.AddWithValue("@" + key, managerEntity.paramsQuery[key] == null ? DBNull.Value : managerEntity.paramsQuery[key]);
                    }
                }

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConexion();
            }
        }

        public void update<T>(ManagerEntity<T> managerEntity)
        {
            FbCommand comm;

            try
            {
                openConexion();
                comm = new FbCommand(managerEntity.sqlUpdate, conexion);

                foreach (string key in managerEntity.paramsQuery.Keys)
                {
                    if (managerEntity.sqlUpdate.Contains("@" + key))
                    {
                        comm.Parameters.AddWithValue("@" + key, managerEntity.paramsQuery[key] == null ? DBNull.Value : managerEntity.paramsQuery[key]);
                    }
                }

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConexion();
            }
        }
    }
}
