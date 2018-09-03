using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int aux = this.tinta + tinta; 
            if (aux >= 0 && aux <= cantidadTintaMaxima)
            {
                this.tinta = (short)aux;
            }
            else if(aux > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else
            {
                this.tinta = -1;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

        public Pintar(int, out string)
        {

        }
    }
}
