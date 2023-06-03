using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class AangetekendeBrief
    {
        private double reisAfstand;
        public double ReisAfstand
        {
            get { return reisAfstand; }
            set
            {
                if (value > 0)
                { 
                    reisAfstand = value; 
                }
            }
        }
        public virtual byte Reistijd
        {
            get
            {
                return (byte)Math.Ceiling(ReisAfstand / 100);
            }
        }
        public virtual double Kostprijs
        {
            get
            {
                return 15 + (10 * ((int)ReisAfstand / 100));
            }
        }
    }
}
