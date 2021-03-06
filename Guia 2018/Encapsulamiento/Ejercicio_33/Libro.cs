﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        #region Fields

        private List<string> paginas = new List<string>();

        #endregion

        #region Propieties

        public string this[int i]
        {
            get
            {
                if (i > paginas.Count || i < 0)
                    return "";
                else
                    return paginas[i];
            }
            set
            {
                if (i >= paginas.Count)
                    paginas.Add(value);
                else if (i >= 0)
                    paginas[i] = value;
            }
        }

        #endregion
    }
}
