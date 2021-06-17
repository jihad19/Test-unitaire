using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcule
{
    public class Moyen
    {
        public double CalculerMoyenne(double Math, double Phisique, double Science)
        {
            double moy;
            int C1 = 5, C2 = 7, C3 =3;
            int total = C1 + C2 + C3;

            moy = (Math * C1 + Phisique * C2 + Science * 3)/ total;



            return moy;
        }
            

    }
}
