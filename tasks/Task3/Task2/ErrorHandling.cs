using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ErrorHandling
    {
        public static void CheckForError<T>(T item)
        {
            if (getType(item) == typeof(string))
            {
                if (string.IsNullOrWhiteSpace(item.ToString())) throw new Exception("Titel darf nicht leer sein");
            }
            else if (getType(item) == typeof(int))
            {
                if (Convert.ToInt32(item) < 0) throw new Exception("Wert darf nicht kleiner 0 sein");
            }
            else
            {
                throw new Exception("Wrong type");
            }
        }

        static Type getType<T>(T item)
        {
            return typeof(T);
        }
    }
}
