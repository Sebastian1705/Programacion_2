using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        #region Campos

        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        #endregion

        #region Metodos

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void Calcularfinal()
        {
            Random r = new Random();
            if (this.nota1 > 3 && this.nota2 > 3)
                this.notaFinal = r.Next(0, 10);
            else
                this.notaFinal = -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} - Apellido: {this.apellido} - Legajo: {this.legajo}");
            if (this.notaFinal != -1)
                sb.AppendFormat($"Nota Final: {this.notaFinal}");
            else
                sb.AppendFormat("Alumno desaprobado");
            sb.AppendLine();
            return sb.ToString();
        }

        #endregion
    }
}
