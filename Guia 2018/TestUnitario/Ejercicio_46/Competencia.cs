using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46
{
    public class Competencia
    {
        #region Fields

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
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

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }       
        }

        public List<VehiculoDeCarrera> Competidores
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
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short vueltas, short competidores, Competencia.TipoDeCompetencia tipo)
            : this()
        {
            this.cantidadCompetidores = competidores;
            this.cantidadVueltas = vueltas;
            this.Tipo = tipo;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            if (c.Tipo == TipoDeCompetencia.f1 && (a is AutoF1))
            {
                foreach (AutoF1 auto in c.competidores)
                {
                    if (auto == (AutoF1)a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            else if (c.Tipo == TipoDeCompetencia.MotoCross && (a is MotoCross))
            {
                foreach (MotoCross moto in c.competidores)
                {
                    if (moto == (MotoCross)a)
                    {
                        retorno = true;
                        break;
                    }

                }
            }
            else
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "==");
            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
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
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            try
            {
                if (c == a)
                {

                }
            }
            catch(CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta","_Competencia", "+", e);
            }
            if (c.competidores.Count <= c.cantidadCompetidores && c != a)
            {
                Random r = new Random();
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)r.Next(15, 100);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
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
