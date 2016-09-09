using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPRO.Model
{
    public class TStat
    {
        public int T_ID { get; set; }
        public double CriticalT { get; set; }
        public double ObservedT { get; set; }
        public double Alpha { get; set; }
        public bool TwoTailed { get; set; }
    }
}
