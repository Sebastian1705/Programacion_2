using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Fields

        private List<Mascota> manada;
        private string nombre;
        TipoManada tipo;

        #endregion

        #region Propieties
        
        public TipoManada TipoManada
        {
            set
            {
                this.tipo = value;
            }
        }
        
        #endregion

        #region Methods

        private Grupo()
        {
            this.manada = new List<Mascota>();
            this.tipo = TipoManada.Unica;
        }

        public Grupo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            :this(nombre)
        {
            this.tipo = tipo;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            
          
            return sb.ToString();
        }

        public static bool operator ==(Grupo e, Mascota j)
        {
            bool retorno = false;
            foreach(Mascota a in e.manada)
            {
                if(a == j)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {

        }

        public static Grupo operator +(Grupo e, Mascota j)
        {

        }

        #endregion
    }
}
