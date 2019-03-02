using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_49
{
    /*a. La clase Competencia deberá tener un tipo genérico, el cual sólo podrá ser del tipo
    VechiuloDeCarrera o uno de sus derivados.
    b. La lista de competidores cambiará del tipo VehiculoDeCarrera al tipo genérico.
    c. Realizar todos los cambios necesarios para que esto funcione correctamente.
    d. NOTA: tener en cuenta que el Test Unitario planteado en el punto 46.d ya no es necesario, y
    podrá lanzar un error en tiempo de diseño*/
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        #region Fields

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoDeCompetencia tipo;

        #endregion

        #region Propieties

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public TipoDeCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public T this[int i]
        {
            get
            {
                return this.competidores[i];
            }       
        }

        public List<T> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        #endregion

        #region Methods

        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public Competencia(short vueltas, short competidores, TipoDeCompetencia tipo)
            : this()
        {
            this.cantidadCompetidores = competidores;
            this.cantidadVueltas = vueltas;
            this.Tipo = tipo;
        }

        public static bool operator ==(Competencia<T> c, T a)
        {
            bool retorno = false;
            if ((c.Tipo == TipoDeCompetencia.f1 && a is AutoF1)
                || (c.Tipo == TipoDeCompetencia.MotoCross && a is MotoCross))
            {
                switch (c.Tipo)
                {
                    case TipoDeCompetencia.f1:
                        foreach (VehiculoDeCarrera auto in c.competidores)
                        {
                            //AutoF1 aux = (AutoF1)Convert.ChangeType(a, typeof(AutoF1));
                            if (auto is AutoF1 && auto == a)
                            {
                                retorno = true;
                                break;
                            }
                        }
                        break;
                    case TipoDeCompetencia.MotoCross:
                        foreach (VehiculoDeCarrera moto in c.competidores)
                        {
                            if (moto is MotoCross && moto == a)
                            {
                                retorno = true;
                                break;
                            }
                        }
                        break;
                }
            }
            else
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "==");
            return retorno;
        }

        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }

        /// <summary>
        /// Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad
        /// de vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un
        /// número random entre 15 y 100 a cantidadCombustible.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator +(Competencia<T> c, T a)
        {
            try
            {
                if (c.competidores.Count <= c.cantidadCompetidores && c != a)
                {
                    Random r = new Random();
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)r.Next(15, 100);
                    return true;
                }
            }
            catch(CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta","_Competencia", "+", e);
            }     
            return false;
        }

        public static bool operator -(Competencia<T> c, T a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (VehiculoDeCarrera a in this.competidores)
            {
                sb.AppendLine(a.MostrarDatos());
            }
            return sb.ToString();
        }

        #endregion

        #region Nested Types

        public enum TipoDeCompetencia
        {
            f1, MotoCross
        }

        #endregion
    }
}
