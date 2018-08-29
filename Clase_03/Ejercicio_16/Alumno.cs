using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void CalcularFinal()
        {
            Random r = new Random();
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = r.Next(0, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("El alumno {1} {0} legajo {2} sacó {3} en el 1er examen y {4} en el 2do", this.apellido, this.nombre, this.legajo, this.nota1, this.nota2);
            if (this.notaFinal != -1)
                sb.AppendFormat(" y su nota final fue {0}", this.notaFinal);

            return sb.ToString();
        }

    }
}
