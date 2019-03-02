using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*f. Clase Agencia:
    i. Crear un delegado llamado DelegadoMensaje por fuera de la clase con la siguiente firma
    “void DelegadoMensaje(string mensaje)” y un evento llamado ​informar ​cuyo tipo será el
    delegado antes mencionado.
    ii. La lista de pasajes se deberá inicializar sólo en el constructor privado.
    iii. El operador == entre Agencia y Pasaje retornará true si el pasaje ya se encuentra en la lista.
    iv. El operador + agregara un pasaje a la lista siempre y cuando este no se encuentre agregado.
    En caso de haber podido agregar el pasaje a la lista, invocar al evento ​informar ​con elmensaje “Pasaje emitido correctamente.”, caso contrario ​informar ​con el mensaje "El pasaje
    ya fue emitido con anterioridad.".
    v. CalcularGanancia retornará la suma del precio final de todos los pasajes vendidos.
    vi. Sólo final: ​Realizar una conversión explícita a string que retorne todos los datos de la
    agencia y sus pasajes vendidos.*/
    public class Agencia
    {
        #region Fields

        public string nombre;
        public List<Pasaje> pasajesVendidos;

        #endregion

        #region Propieties

        public string Nombre { get => nombre; set => nombre = value; }

        public List<Pasaje> PasajesVendidos { get => pasajesVendidos; set => pasajesVendidos = value; }

        #endregion

        #region Methods

        private Agencia()
        {
            this.PasajesVendidos = new List<Pasaje>();
        }

        public Agencia(string nombre)
            : this()
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Agencia a, Pasaje p)
        {
            foreach(Pasaje item in a.PasajesVendidos)
            {
                if (item == p)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Agencia a, Pasaje p)
        {
            return !(a == p);
        }

        public static Agencia operator+(Agencia a, Pasaje p)
        {
            if (a != p)
            {
                a.PasajesVendidos.Add(p);
                a.informar.Invoke("Pasaje emitido correctamente.");
            }          
            else
                a.informar.Invoke("El pasaje ya fue emitido con anterioridad.");
            return a;
        }

        public static explicit operator string(Agencia a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE AGENCIA: {a.Nombre} \n");
            sb.AppendLine($"PASAJES VENDIDOS");
            sb.AppendLine($"-------------------------------------");
            foreach(Pasaje item in a.pasajesVendidos)
            {
                sb.AppendLine($"{item.Mostrar()}");
            }
            sb.AppendLine($"-------------------------------------");
            sb.AppendLine($"GANANCIA: {a.CalcularGanancia()}");
            return sb.ToString();
        }

        public float CalcularGanancia()
        {
            float retorno = 0;
            foreach(Pasaje item in this.PasajesVendidos)
            {
                retorno += item.PrecioFinal;
            }
            return retorno;
        }

        #endregion

        #region Events

        public event DelegadoMensaje informar;

        #endregion

    }
}
