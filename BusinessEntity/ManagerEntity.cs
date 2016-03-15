using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BusinessEntity
{
    public class ManagerEntity<T>
    {
        public string sqlInsert = "";
        public string sqlDelete = "";
        public string sqlUpdate = "";
        public string sqlGet = "";
        public string sqlListAll = "";
        public string sqlWhere = "";
        public string sqlLastId = "";
        public Dictionary<string, object> paramsQuery;
        public static bool disablePrimaryKey = false;

        public ManagerEntity()
        {
            //disablePrimaryKey = false;
        }

        public List<T> serialize(System.Data.DataTable table)
        {
            List<T> list = new List<T>();
            if (table != null)
            {
                foreach (System.Data.DataRow row in table.Rows)
                {
                    Type type = typeof(T);
                    T instance = (T)Activator.CreateInstance(type);
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo prop in properties)
                    {
                        DDLProperties att = (DDLProperties)Attribute.GetCustomAttribute(prop, typeof(DDLProperties));
                        if (att != null)
                        {
                            try
                            {
                                if (row.Table.Columns.Contains(att.name))
                                {
                                    object value = row[att.name];

                                    if (value.GetType() != typeof(System.DBNull))
                                    {
                                        if (att.type != null && att.type.Equals(System.Data.SqlDbType.Bit))
                                        {
                                            prop.GetSetMethod().Invoke(instance, new object[] { Convert.ToBoolean(value) });
                                        }
                                        else {
                                            prop.GetSetMethod().Invoke(instance, new object[] { value });
                                        }
                                        
                                    }

                                }
                            }
                            catch (Exception ex)
                            {
                                //Utilidades.Logger.debug(ex.Message);
                            }
                        }
                    }

                    list.Add(instance);
                }
            }

            return list;
        }

        public void prepareInsertQuery(T entity)
        {

            paramsQuery = new Dictionary<string, object>();
            sqlInsert = "";

            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];

            if (attTable != null)
            {
                List<string> fieldsName = new List<string>();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo prop in properties)
                {
                    DDLProperties att = (DDLProperties)Attribute.GetCustomAttribute(prop, typeof(DDLProperties));
                    
                    if (att != null && !att.isIdentity && att.insertable)
                    {
                        fieldsName.Add(att.name);
                        paramsQuery.Add(att.name, prop.GetGetMethod().Invoke(entity, null));
                    }
                    else if (disablePrimaryKey && att != null && att.insertable)
                    {
                        fieldsName.Add(att.name);
                        paramsQuery.Add(att.name, prop.GetGetMethod().Invoke(entity, null));
                    }
                }

                sqlInsert = "Insert into " + attTable.name + "(" + String.Join(",", fieldsName.ToArray()) + ") values " +
                    "(@" + String.Join(",@", fieldsName.ToArray()) + ")";
            }
        }

        public string sqlExistRowById(int id)
        {            
            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];
            DDLId idTable = (DDLId)type.GetCustomAttributes(typeof(DDLId), true)[0];
            return "Select count(*) From " + attTable.name + " Where " + idTable.name + " = " + id;
        }

        public string sqlSelectMaxId()
        {
            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];
            DDLId idTable = (DDLId)type.GetCustomAttributes(typeof(DDLId), true)[0];
            return "Select max("+idTable.name+") From " + attTable.name;
        }

        public void prepareUpdateQuery(T entity)
        {
            paramsQuery = new Dictionary<string, object>();
            sqlUpdate = "";
            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];
            DDLProperties att;

            if (attTable != null)
            {
                List<string> fieldsName = new List<string>();
                PropertyInfo[] properties = type.GetProperties();
                
                foreach (PropertyInfo prop in properties)
                {
                    att = (DDLProperties)Attribute.GetCustomAttribute(prop, typeof(DDLProperties));

                    try
                    {
                        if (att != null && !att.isIdentity && att.updatable)
                        {
                            fieldsName.Add(att.name + "=@" + att.name);
                            paramsQuery.Add(att.name, prop.GetGetMethod().Invoke(entity, null));
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message + " Property: " + att.name);
                    }
                }

                object[] idsTable = type.GetCustomAttributes(typeof(DDLId), true);
                sqlUpdate = "Update " + attTable.name + " Set " + String.Join(",", fieldsName.ToArray());
                sqlUpdate += " Where ";
                List<string> listWhere = new List<string>();

                foreach (object obj in idsTable)
                {
                    DDLId idTable = (DDLId)obj;
                    listWhere.Add(idTable.name + " = @pk" + idTable.name);
                    paramsQuery.Add("pk" + idTable.name, type.GetProperty(idTable.nameProperty).GetGetMethod().Invoke(entity, null));
                }

                sqlUpdate += String.Join(" AND ", listWhere.ToArray());
            }
        }

        public string getUpdateQuery(T entity)
        {
            paramsQuery = new Dictionary<string, object>();
            string sql = "";
            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];
            DDLProperties att;

            if (attTable != null)
            {
                List<string> fieldsName = new List<string>();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo prop in properties)
                {
                    att = (DDLProperties)Attribute.GetCustomAttribute(prop, typeof(DDLProperties));

                    try
                    {
                        if (att != null && !att.isIdentity && att.updatable)
                        {
                            fieldsName.Add(att.name + "=@" + att.name);
                            paramsQuery.Add(att.name, prop.GetGetMethod().Invoke(entity, null));
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message + " Property: " + att.name);
                    }
                }

                object[] idsTable = type.GetCustomAttributes(typeof(DDLId), true);
                sql = "Update " + attTable.name + " Set " + String.Join(",", fieldsName.ToArray());
                
            }

            return sql;
        }

        public void prepareDelete(T entity)
        {
            paramsQuery = new Dictionary<string, object>();
            sqlDelete = "Delete From ";
            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];

            object[] idsTable = type.GetCustomAttributes(typeof(DDLId), true);
            sqlDelete += attTable.name + " Where ";
            List<string> listWhere = new List<string>();

            foreach (object obj in idsTable)
            {
                DDLId idTable = (DDLId)obj;
                listWhere.Add(idTable.name + " = @" + idTable.name);
                paramsQuery.Add(idTable.name, type.GetProperty(idTable.nameProperty).GetGetMethod().Invoke(entity, null));
            }

            sqlDelete += String.Join(" AND ", listWhere.ToArray());
        }

        public void prepareGet(object id)
        {
            paramsQuery = new Dictionary<string, object>();
            sqlGet = "Select * From ";
            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];
            DDLId idTable = (DDLId)type.GetCustomAttributes(typeof(DDLId), true)[0];
            sqlGet += attTable.name + " Where " + idTable.name + " = @" + idTable.name;
            paramsQuery.Add(idTable.name, id);
        }

        public void prepareListAll()
        {
            prepareListAll(false);
        }

        public void prepareListAll(bool withWhere)
        {
            paramsQuery = new Dictionary<string, object>();
            sqlListAll = "Select * From ";
            Type type = typeof(T);
            DDLTable attTable = (DDLTable)type.GetCustomAttributes(typeof(DDLTable), true)[0];
            DDLId idTable = (DDLId)type.GetCustomAttributes(typeof(DDLId), true)[0];
            sqlListAll += attTable.name;

            try
            {
                if (withWhere == false && type.GetCustomAttributes(typeof(DDLOrderBy), true).Length > 0)
                {
                    DDLOrderBy orderBy = (DDLOrderBy)type.GetCustomAttributes(typeof(DDLOrderBy), true)[0];
                    sqlListAll += " order by " + orderBy.orderby;
                }           
            }
            catch (Exception)
            {

            }
        }

        public void addWhere(string field)
        {
            if (sqlWhere.Equals(""))
            {                
                sqlWhere = " Where " + field + "= @" + field;               
            }
            else
            {
                sqlWhere = " and " + field + "= @" + field;                
            }

            sqlListAll += sqlWhere;           
        }

        public void addOrderBy()
        {
            try
            {
                Type type = typeof(T);
                if (type.GetCustomAttributes(typeof(DDLOrderBy), true).Length > 0)
                {
                    DDLOrderBy orderBy = (DDLOrderBy)type.GetCustomAttributes(typeof(DDLOrderBy), true)[0];
                    sqlListAll += " order by " + orderBy.orderby;
                }     
            }
            catch (Exception)
            {
                
            }
        }
    }
}
