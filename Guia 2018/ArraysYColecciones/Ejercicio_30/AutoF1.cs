using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    /*AutoF1:
    a. Al generar un auto se cargará enCompetencia como falso y cantidadCombustible y
    vueltasRestantes en 0.
    b. Dos autos serán iguales si el número y escudería son iguales.c. Realizar los métodos getters y setters para cantidadCombustible, enCompetencia y
    vueltasRestantes.*/
    public class AutoF1
    {
        #region Fields

        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #endregion

        #region Methods

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.escuderia == a2.escuderia && a1.numero == a2.numero)
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {this.numero} - Escuderia: {this.escuderia} - Combustible: {this.cantidadCombustible} - Restantes: {vueltasRestantes}");
            return sb.ToString();
        }

        #endregion
    }
}
