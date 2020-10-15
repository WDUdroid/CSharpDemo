using System;
using System.Collections.Generic;
using System.Text;

namespace Mensch
{
    public class Haustier
    {
        public Haustier(ITier haustier)
        {
            this.spezies = haustier;
        }

        public Haustier()
        {
            this.spezies = new Hund();
        }

        public ITier spezies { get; set; }

    }
}