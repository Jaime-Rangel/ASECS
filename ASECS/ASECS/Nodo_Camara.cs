using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    public class Nodo_Camara<T>
    {
        public T data
        {
            get;
            set;
        }

        public Nodo_Camara<T> left
        {
            set;
            get;
        }

        public Nodo_Camara<T> right
        {
            set;
            get;
        }

        public Nodo_Camara(T data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
