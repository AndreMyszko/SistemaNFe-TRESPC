using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcVLSM_Final;

namespace CalcVLSM_Final.Model
{
    class ModelCalc
    {
        public string DefinirClasse_IP(int ip1)
        {
            string classe;

            if (ip1 <= 127 && ip1 >= 0)
            {
                classe = "A";

                return classe;
            }

            else if (ip1 <= 191)
            {
                classe = "B";

                return classe;
            }

            else if (ip1 <= 224)
            {
                classe = "C";

                return classe;
            }

            else
            {
                classe = "Errou!";

                return classe;
            }
        }

    }
}
