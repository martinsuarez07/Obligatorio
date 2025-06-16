﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comparadores
{
    public class CompararPasajePorFecha : IComparer<Pasaje>
    {
        public int Compare(Pasaje? x, Pasaje? y)
        {
            return x.Fecha.CompareTo(y.Fecha);
        }
    }
}
