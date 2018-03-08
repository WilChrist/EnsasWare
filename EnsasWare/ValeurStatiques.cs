using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsasWare
{
    static class ValeurStatiques
    {
        static Boolean logged;
        static ValeurStatiques()
        {
            Logged = new Boolean(); Logged = false;
        }

        public static bool Logged { get => logged; set => logged = value; }
    }
}
