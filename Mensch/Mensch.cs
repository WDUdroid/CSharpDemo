using System;
using System.Collections.Generic;
using System.Text;

namespace Mensch
{
    public class Mensch
    {
        private List<Haustier> _haustiere;

        public Mensch(List<Haustier> haustiere)
        {
            this._haustiere = haustiere;
        }
    }
}