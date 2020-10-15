using System;
using System.Collections.Generic;
using System.Text;

namespace Mensch
{
    public interface ITier
    {
        string name { get; set; }

        void laut();
    }
}