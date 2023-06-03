using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class InternationaleAangetekendeBrief : AangetekendeBrief
    {
        public override byte Reistijd
        {
            get
            {
                return (byte)Math.Ceiling(ReisAfstand / 50);
            }
        }
        private double kostprijs;
        public override double Kostprijs
        {

            get
            {
                return 20 * ((int)Math.Ceiling(ReisAfstand / 100) );
            }
        }
    }
}
