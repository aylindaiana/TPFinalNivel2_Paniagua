﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domino
{
    internal class Marca
    {
        public int Id { get; set; }
        public string Descipcion { get; set; }

        public override string ToString()
        {
            return Descipcion;
        }
    }
}
