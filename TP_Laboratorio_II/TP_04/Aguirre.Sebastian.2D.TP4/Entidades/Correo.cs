using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Fields

        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        #endregion

        #region Propieties

        /// <summary>
        /// Propiedad de lectura / escritura.
        /// </summary>
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Constructor por defecto.
        /// Inicializa las listas.
        /// </summary>
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.Paquetes = new List<Paquete>();
        }

        /// <summary>
        /// Sobrecarga operador +.
        /// Agrega el elemento a la lista y crea el hilo para el mockPaquetes.
        /// </summary>
        /// <param name="c">Correo al que se le agregara el paquete.</param>
        /// <param name="p">Paquete a comparar y agregar a la lista.</param>
        /// <returns>Retorna el Correo pasado como parametro si se agrego, sino lanza una excepcion.</returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            if(!(c is null) && !(p is null))
            {
                foreach(Paquete item in c.Paquetes)
                {
                    if(item == p)
                    {
                        throw new TrackingIDRepetidoException($"El paquete {p.TrackingID} ya esta en la lista.");
                    }
                }
                c.Paquetes.Add(p);
                Thread hilo = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(hilo);
                hilo.Start();
            }
            return c;
        }

        /// <summary>
        /// Muestra la lista de paquetes del correo.
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns>Datos de c/u de los paquetes.</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> l = ((Correo)elementos).paquetes;
            StringBuilder sb = new StringBuilder();
            foreach(Paquete item in l)
            {
                sb.AppendLine($"{item.ToString()} ({item.Estado.ToString()})");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Recorre la lista de hilos y mata los procesos activos.
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }

        #endregion
    }
}
