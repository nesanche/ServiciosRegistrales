using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class GenericBL<T>
    {

        public static List<T> listTodos()
        {
            return new GenericDL<T>().listarTodos();
        }

        public static List<T> listTodos(Dictionary<string, object> param)
        {
            return new GenericDL<T>().listarTodos(param);
        }

        public static List<T> listActivos()
        {
            Dictionary<string, object> filtro = new Dictionary<string, object>();
            filtro.Add("campo_baja", 0);
            return new GenericDL<T>().listarTodos(filtro);
        }

        public static List<T> listActivos(Dictionary<string, object> param)
        {
            param.Add("campo_baja", 0);
            List<T> list =  new GenericDL<T>().listarTodos(param);
            param.Remove("campo_baja");
            return list;
        }
       
        public static T get(object id)
        {
            return new GenericDL<T>().get(id);
        }

        public static void delete(T entity)
        {
            new GenericDL<T>().delete(entity);
        }

        public static void update(T entity)
        {
            new GenericDL<T>().update(entity);
        }

        public static void insert(T entity)
        {
            new GenericDL<T>().insert(entity);
        }

        public static object insertReturnId(T entity)
        {
            return new GenericDL<T>().insertReturnId(entity);
        }

        public static int getNextId()
        {
            return new GenericDL<T>().nextId();
        }
    }
}
