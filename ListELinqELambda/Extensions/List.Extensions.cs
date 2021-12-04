using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Equivalente a ListExtensions.PushName<>(list, params);
        /// </summary>
        /// <typeparam name="T">Parametro generico T</typeparam>
        /// <param name="list">lista do System.Collections</param>
        /// <param name="items">Items a serem adicionas do mesmo tipo de T</param>
        public static void PushMany<T>(this List<T> list, params T[] items)
        {
            foreach(var item in items) {
                list.Add(item);
                    
            }
        } // se T do metodo e diferente dos parametros entao na chamada eu devo dizer o tipo da lista
    }
}
