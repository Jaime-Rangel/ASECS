using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    public class Arbol_Camara<T>
    {
        public Nodo_Camara<T> root;

        private Func<T, T, bool> comparator;

        private Func<T, Camara> retornar_parametros;

        private Func<T, T,bool> comparar_alias;

        private Func<T, T, bool> comparar_id;

        private const int LEFT = 0;
        private const int RIGHT = 1;

        public Arbol_Camara(Func<T, T, bool> comparator, Func<T, Camara> retornar_parametros, Func<T, T, bool> comparar_alias,Func<T,T,bool> comparar_id)
        {
            this.comparator = comparator;
            this.retornar_parametros = retornar_parametros;
            this.comparar_alias = comparar_alias;
            this.comparar_id = comparar_id;
        }

        public Camara Buscar(T data)
        {
            Nodo_Camara<T> currentNode = root;

            while (currentNode != null)
            {
                if (comparar_alias(data, currentNode.data) == true)
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

        public void Actualizar(T data)
        {
            Nodo_Camara<T> currentNode = root;

            while (currentNode != null)
            {
                if (comparar_id(data, currentNode.data) == true)
                {
                    currentNode.data = data;
                    break;
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

        public bool remove(T data)
        {
            return remove(root, data);
        }

        private bool remove(Nodo_Camara<T> node, T data)
        {
            Nodo_Camara<T> parent = null;

            int lastTurn = 0;

            //step 1:

            while (node != null)
            {
                if (comparar_alias(data,node.data))
                {
                    break;
                }
                else
                    if (comparator(data, node.data))
                    {
                        //left
                        parent = node;
                        node = node.left;
                        lastTurn = LEFT;
                    }
                    else
                    {
                        //right
                        parent = node;
                        node = node.right;
                        lastTurn = RIGHT;
                    }
            }

            //nodo no existe
            if (node == null)
            {
                return false;
            }

            //step 2.
            //es raiz
            bool isRoot = (parent == null);

            if (isRoot)
            {
                // si no tiene hijos eliminar
                if (node.left == null && node.right == null)
                {
                root = null;
                }
                else
                if (node.left != null && node.right == null)
                {
                root = node.left;
                }
                else
                if (node.left == null && node.right != null)
                {
                root = node.right;
                }
                else
                {
                //con dos hijos
                Nodo_Camara<T> temp = Obtener_Valor_Menor(node.right);

                root.data = temp.data;
                remove(node.right, temp.data);
                }

            }
            else
            {
                int childrenCount = 0;

                if (node.left != null)
                {
                    childrenCount++;
                }

                if (node.right != null)
                {
                    childrenCount++;
                }

                if (childrenCount == 0)
                {
                    if (lastTurn == LEFT)
                    {
                        parent.left = null;
                    }
                    else
                    {
                        parent.right = null;
                    }
                }
                else if (childrenCount == 1)
                {

                    Nodo_Camara<T> singleChild = node.left;

                    if (lastTurn == LEFT)
                    {
                        //parent.left points node single child
                        parent.left = singleChild;
                    }
                    else
                    {
                        //parent.right points to single child
                        parent.right = singleChild;
                    }
                }
                else
                {
                    Nodo_Camara<T> minimum = node.right;

                    while (minimum.left != null)
                    {
                        minimum = minimum.left;
                    }

                    node.data = minimum.data;

                    remove(node.right, minimum.data);
                }
            }

            return true;
        }

        public Nodo_Camara<T> Obtener_Valor_Menor(Nodo_Camara<T> node)
        {
            Nodo_Camara<T> minimum = node;

            while (minimum.left != null)
                minimum = minimum.left;

            return minimum;
        }
    }
}
