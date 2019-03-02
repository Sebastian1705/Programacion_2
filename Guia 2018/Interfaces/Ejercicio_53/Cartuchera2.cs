using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    /*c. Declarar la clase Cartuchera2 que tendrá dos objetos del tipo List con los miembro
    genéricos Boligrafo y Lapiz respectivamente.
    d. Crear el método ProbarElementos para que haga exactamente lo mismo que el de
    Cartuchera1. Recorrer cada lista por su tipo, por ejemplo foreach(Lapiz l in lista).*/
    public class Cartuchera2<T, U> where T : Lapiz where U : Boligrafo
    {
        #region Fields

        private List<T> lapices;
        private List<U> boligrafos;

        #endregion

        #region Propieties

        public List<T> Lapices
        {
            get
            {
                return this.lapices;
            }
        }

        public List<U> Boligrafos
        {
            get
            {
                return this.boligrafos;
            }
        }

        #endregion

        #region Methods

        public Cartuchera2()
        {
            this.lapices = new List<T>();
            this.boligrafos = new List<U>();
        }

        public bool ProbarElementos()
        {
            bool retorno = false;
            foreach (Lapiz aux in this.Lapices)
            {
                if (((IAcciones)aux).UnidadesDeEscritura >= 1)
                    ((IAcciones)aux).Escribir("LapizLapiz"); //0.1 por caracter
                else
                    retorno = false;

                if (((IAcciones)aux).UnidadesDeEscritura < 1)
                    ((IAcciones)aux).Recargar(1);
            }
            try
            {
                foreach (Boligrafo aux in this.Boligrafos)
                {
                    if (aux.UnidadesDeEscritura >= 1)
                        aux.Escribir("Bol"); //0.3 por caracter
                    else
                        retorno = false;

                    if (aux.UnidadesDeEscritura < 1)
                        aux.Recargar(1);
                }
            }
            catch(NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }


        #endregion
    }
}
