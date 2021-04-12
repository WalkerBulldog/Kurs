using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Drivers;


namespace ORM
{
    /// <summary>
    /// Коллекция любых объектов (генерик).
    /// </summary>
    /// <typeparam name="T">Текущий тип.</typeparam>
    public class ObjectFabric<T>
    {
        private readonly List<T> objects = new List<T>();

        private Type[] GetParamTypes(params object[] arguments)
        {
            var types = from value in arguments
                        select value.GetType();
            return types.ToArray();
        }
        public T GetObject(params object[] arguments)
        {
            Type[] types = GetParamTypes(arguments);
            var constructorInfo = typeof(T).GetConstructor(types);
            T currentObject = (T)constructorInfo.Invoke(arguments);
            if(!objects.Contains(currentObject))
            {
                objects.Add(currentObject);
            }
            return currentObject;
        }
    }
}
