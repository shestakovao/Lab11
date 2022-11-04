using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Liner
    {
        double k;
        double b;

        public Liner(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if ((k == 0) && (b == 0))
            {
                return "Корень любое значение x";
            }
            else
            if (k == 0)
            {
                return "Найти корень не возможно!";
            }
            else
            {
                double x = -b / k;
                return $"Корень уравнения {x:f3}";
            }
        }
    }
}
