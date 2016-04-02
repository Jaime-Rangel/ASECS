using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    class Arbol_Camara<T>
    {
        public Nodo_Camara<T> root;

        private Func<T, T, bool> comparator;

        private Func<T, Camara> retornar_parametros;

        private Func<T, T,bool> comparar_alias;

        public Arbol_Camara(Func<T, T, bool> comparator, Func<T,Camara> retornar_parametros,Func<T, T,bool> comparar_alias)
        {
            this.comparator = comparator;
            this.retornar_parametros = retornar_parametros;
            this.comparar_alias = comparar_alias;
        }

        public Camara Buscar(T data)
        {
            Nodo_Camara<T> currentNode = root;

            while (currentNode != null)
            {
                if (comparar_alias(data,currentNode.data)==true)
                {
                    return retornar_parametros(currentNode.data);
                }
                else
                {
                    if (comparator(data, currentNode.data))
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }

            return null;
        }

        public void Insertar(T data)
        {
            if (root == null)
            {
                root = new Nodo_Camara<T>(data);
            }
            else
            {
                var currentNode = root;

                bool inserted = false;

                while (!inserted)
                {
                    //if (data < current.data)
                    if (comparator(data, currentNode.data))
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = new Nodo_Camara<T>(data);
                            inserted = true;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = new Nodo_Camara<T>(data);
                            inserted = true;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            }
        }
    }
}
