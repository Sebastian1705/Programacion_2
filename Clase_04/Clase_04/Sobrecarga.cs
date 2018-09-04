using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_04
{
    class Sobrecarga
    {
        public string tipoNumero;

        public Sobrecarga() : this("Metro")
        {
            tipoNumero = "Metro";
        }

        public Sobrecarga(string tipo)
        {
            tipoNumero = tipo;
        }

        public int Sumar(int a, int b) 
        {
            if (tipoNumero == "Metro")
                return (a + b);

            else
                return (a + b) * 100;
        }

        public static int Sumar(float a, float b) 
        {
            return (int)(a + b);
        }

        public int Sumar(int a, int b, int c) 
        {
            return a + b + c;
        }

        public float Sumar(float a, int b) 
        {
            return a + (b*100);
        }

        public float Sumar(int a, float b)
        {
            return Sumar(a, b);
        }

    }
}
