using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53
{
    /*a. Declarar la clase Cartuchera1 que tendrá un objeto del tipo List con el miembro genérico
    IAcciones.
    b. Crear el método ProbarElementos
    i. Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
    ii. Cuando sea necesario, recargará antes de salir del método.
    iii. Retornará true si todos los bolígrafos pudieron gastar exactamente las 1 unidades.*/
    public class Cartuchera1
    {
        #region Fields

        private List<IAcciones> lista;

        #endregion

        #region Propieties

        public List<IAcciones> Lista;

        #endregion

        #region Methods

        public Cartuchera1()
        {
            this.lista = new List<IAcciones>();
        }

        public bool ProbarElementos()
        {
            try
            {
                foreach (IAcciones item in this.Lista)
                {
                    if (item.UnidadesDeEscritura > 1)
                    {
                        if (item is Lapiz)
                            item.Escribir("LapizLapiz");
                        if (item is Boligrafo)
                            item.Escribir("Bol");
                    }
                    else
                        return false;
                    if (item.UnidadesDeEscritura < 1)
                        item.Recargar(1);
                }
                return true;

            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        #endregion
    }
}
