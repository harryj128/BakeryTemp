using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryTemp
{
    public class TConv
    {
        public TConv(double degF) => Degf = degF;  // default constructor
        public double Degf { get; private set; }
        public double Degc { get => (Degf - 32) / 9.0 * 5; }

        public static TConv operator +(TConv a, TConv b)
        {
            return new TConv(a.Degf + b.Degf);
        }
        public static TConv operator /(TConv a, int b)
        {
            return new TConv(a.Degf / b);
        }
    }

    public class TAvg
    {
        public TConv Average(IEnumerable<TConv> convs)
        {
            TConv total = new TConv(0);
            foreach (TConv item in convs)
            {
                total += item;
            }

            return (total / convs.Count()); 
        }
    }
}
