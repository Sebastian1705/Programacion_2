﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaException
{
    public class Centralita
    {
        #region Fields

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region Propieties

        public float GanananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GanananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GanananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Methods

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gLocal = 0, gPrivincial = 0, retorno = 0;
            foreach (Llamada item in this.Llamadas)
            {
                if (item is Local)
                    gLocal += ((Local)item).CostoLlamada;
                else if (item is Provincial)
                    gPrivincial += ((Provincial)item).CostoLlamada;
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = gLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = gPrivincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = gLocal + gPrivincial;
                    break;
            }
            return retorno;
        }
    
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Centralita: {this.razonSocial}");
            sb.AppendLine("Ganancias");
            sb.AppendLine($"Local: {this.GanananciasPorLocal} - Provincial: {this.GanananciasPorProvincial} - Total: {this.GanananciasPorTotal}");
            foreach(Llamada item in this.Llamadas)
            {
                if (item is Local)
                    sb.AppendLine(((Local)item).ToString());
                else if (item is Provincial)
                    sb.AppendLine(((Provincial)item).ToString());
            }
            return sb.ToString(); ;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (!(nuevaLlamada is null))
                this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach(Llamada item in c.Llamadas)
            {
                if (item == l)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (c != l)
                c.AgregarLlamada(l); 
            else
                throw new CentralitaException("No se pudo cargar, ya existe llamada", c.GetType().Name.ToString(), "+");
            return c;
        }

        #endregion

    }
}
