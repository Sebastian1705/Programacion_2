using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17
{
    public class MiLista<T> : IEnumerable<T>
    {
        private T[] lista;

        public int DatoDeMiLista
        {
            get
            {
                return 5;
            }
            set
            {
                if (value != 5)
                    throw new Exception();
            }
        }

        public MiLista()
        {
            this.lista = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref lista, lista.Length + 1);
            this.lista[lista.Length - 1] = item;
        }

        public void Remove(T item)
        {
            for(int i = 0; i < lista.Length; i++)
            {
                if(lista[i].Equals(item))
                {
                    for(int j = i + 1; i < lista.Length; j++)
                    {
                        lista[i] = lista[j];
                    }
                }
            }
            Array.Resize(ref lista, lista.Length - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.lista[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for(int i = 0; i < this.Count; i++)
            {
                yield return this.lista[i];
            }
        }

        public int Count
        {
            get
            {
                return lista.Length;
            }
        }


    }
}
