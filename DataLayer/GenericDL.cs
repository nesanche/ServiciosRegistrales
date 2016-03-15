using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BusinessEntity;

namespace DataLayer
{
    public class GenericDL<T> 
    {
        public List<T> listarTodos()
        {
            ManagerEntity<T> manager = new BusinessEntity.ManagerEntity<T>();
            manager.prepareListAll();
            return manager.serialize(new dbHelper().query(manager.sqlListAll, manager.paramsQuery));
        }

        public bool existRowById(int id)
        {
            ManagerEntity<T> manager = new BusinessEntity.ManagerEntity<T>();
            return int.Parse(new dbHelper().query(manager.sqlExistRowById(id), null).Rows[0][0].ToString()) > 0;
        }

        public List<T> listarTodos(Dictionary<string, object> param)
        {
            ManagerEntity<T> manager = new ManagerEntity<T>();
            manager.prepareListAll(true);
            foreach (string item in param.Keys)
            {
                manager.addWhere(item);
            }
            manager.addOrderBy();

            List<T> list = manager.serialize(new dbHelper().query(manager.sqlListAll, param));
            return list;
        }

        public T get(object id)
        {
            ManagerEntity<T> manager = new ManagerEntity<T>();
            manager.prepareGet(id);
            List<T> list = manager.serialize(new dbHelper().get<T>(manager));
            if (list.Count == 0)
            {
                return default(T);
            }

            return list[0];
        }

        public void insert(T entity)
        {
            ManagerEntity<T> manager = new ManagerEntity<T>();
            manager.prepareInsertQuery(entity);
            new dbHelper().insert<T>(manager);
        }

        public int insertReturnId(T entity)
        {
            ManagerEntity<T> manager = new ManagerEntity<T>();
            manager.prepareInsertQuery(entity);
            return new dbHelper().insertReturnId<T>(manager);
        }

        public void delete(T entity)
        {
            ManagerEntity<T> manager = new ManagerEntity<T>();
            manager.prepareDelete(entity);
            new dbHelper().delete<T>(manager);
        }

        public void update(T entity)
        {
            ManagerEntity<T> manager = new ManagerEntity<T>();
            manager.prepareUpdateQuery(entity);
            new dbHelper().update<T>(manager);
        }

        public List<T> listBySql(String sql, Dictionary<string, object> param)
        {
            List<T> list = new List<T>();
            ManagerEntity<T> manager = new ManagerEntity<T>();
            list = manager.serialize(new dbHelper().query(sql, param));
            return list;
        }

        public int nextId()
        {
            ManagerEntity<T> manager = new ManagerEntity<T>();
            return new dbHelper().getNextId<T>(manager);
        }

    }
}
