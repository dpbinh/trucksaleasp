using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Utils
{
    public class BeanUtil
    {
        public static IList<E> ConvertToList<T, E>(IList<T> source)
        {
            IList<E> result = new List<E>();
            foreach(T t in source)
            {
                E e = (E)Activator.CreateInstance(typeof(E), t);
                result.Add(e);
            }

            return result;
        }
    }
}