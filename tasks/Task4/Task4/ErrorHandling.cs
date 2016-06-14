using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ErrorHandling
    {
        public static void CheckForError<T>(T item)
        {
            if (GetType(item) == typeof(string))
            {
                if (string.IsNullOrWhiteSpace(item.ToString())) throw new Exception("Titel darf nicht leer sein");
            }
            else if (GetType(item) == typeof(int))
            {
                if (Convert.ToInt32(item) < 0) throw new Exception("Wert darf nicht kleiner 0 sein");
            }
            else
            {
                throw new Exception("Wrong type");
            }
        }

        /// <summary>
        /// vergleicht ob die beiden parameter den gleiche ntypen haben
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">param zum vergleichen</param>
        /// <param name="erwartet">erwarteter datentyp</param>
        public static void CheckforType<T>(T item, T erwartet)
        {
            if (!erwartet.Equals(GetType(item)))
            {
                throw new Exception($"Erwartet wurde: {erwartet} bekommen -> {GetType(item)} ");
            }
        }

        static Type GetType<T>(T item)
        {
            return item.GetType();
        }
    }
}
