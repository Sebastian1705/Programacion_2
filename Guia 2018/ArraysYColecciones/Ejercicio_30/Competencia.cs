using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    /*Competencia:
    d. El constructor privado será el único capaz de inicializar la lista de competidores.
    e. La sobrecarga + agregará un competidor si es que aún hay espacio (validar con
    cantidadCompetidores) y el competidor no forma parte de la lista (== entre Competencia y
    AutoF1).
    f. Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad
    de vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un
    número random entre 15 y 100 a cantidadCombustible.*/
    public class Competencia
    {
        #region Fields

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        #endregion

        #region Methods

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short vueltas, short competidores)
            : this()
        {
            this.cantidadCompetidores = competidores;
            this.cantidadVueltas = vueltas;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 item in c.competidores)
            {
                if (item == a)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static Competencia operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count <= c.cantidadCompetidores && c != a)
            {
                Random r = new Random();
                
            }
            return c;
        }

        #endregion
    }
}
