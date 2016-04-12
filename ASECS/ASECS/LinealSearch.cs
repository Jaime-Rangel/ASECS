using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class LinealSearch
    {
        public static List<T> findMany<T>(List<T> A, Func<T, bool> lambda)
        {
            List<T> lista = new List<T>();
            for (int i = 0; i < A.Count; i++)
            {
                bool found = lambda(A[i]);
                if (found)
                {
                    lista.Add(A[i]);
                }
            }
            return lista;
        }
        public static int indexOf_Generico_Lamba<T>(List<T> A, Func<T, bool> lambda)
        {
            for (int i = 0; i < A.Count; i++)
            {
                bool found = lambda(A[i]);

                if (found)
                {
                    return i;
                }
            }
            return -1;
        }
        public static List<T> list<T>(List<T> A, Func<T, bool> lambda)
        {
            List<T> lista = new List<T>();

            for (int i = 0; i < A.Count; i++)
            {
                bool found = lambda(A[i]);

                if (found)
                {
                    lista.Add(A[i]);
                }

            }

            return lista;

        }
    }
}
