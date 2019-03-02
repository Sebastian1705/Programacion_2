using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class VehiculoDeCarrera
    {
        #region Fields

        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #endregion

        #region Propieties

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        #endregion

        #region Methods

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
            this.EnCompetencia = false;
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            if (v1.Escuderia == v2.Escuderia && v1.Numero == v2.Numero)
                return true;
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        public string MostrarDatos()
        {
            return String.Format($"Numero: {this.Numero} - En Comp: {this.EnCompetencia} - Escuderia: {this.Escuderia} " +
                $"Vueltas restantes: {this.VueltasRestantes} - Combustible: {this.CantidadCombustible}");
        }

        #endregion
    }
}
