using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesGenericas
{
    class Stack <T>
    {
        private int position = 0;
        private T[] datos;

        public Stack()
        {
            datos = new T[10];
        }

        public Stack(int tamanio)
        {
            datos = new T[tamanio];
        }

        public void Push(T objeto)
        {
            datos[position++] = objeto;
        }

        public T pop()
        {
            return datos[--position];
        }
    }
}
