﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeFichier
{
    public abstract class Element
    {
        private string Nom { get; set; }
        public abstract int getTaille();
    }
}
