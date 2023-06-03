using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class HogePrioriteitsAangetekendeBrief : AangetekendeBrief
    {
        public override byte Reistijd
        {
            get
            {
                return (byte)Math.Ceiling(ReisAfstand / 200);
            }
        }
        public override double Kostprijs
        {

            get
            {
                return 30 * ((int)ReisAfstand / 100);
            }
        }
    }
}
