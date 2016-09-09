using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ZPRO.Model
{
    [XmlRoot]
    public class ZStat
    {
        [XmlIgnore]
        public int Z_ID { get; set; }

        [XmlAttribute]
        public double CriticalZ { get; set; }

        [XmlAttribute]
        public double ObservedZ { get; set; }

        [XmlAttribute]
        public double Alpha { get; set; }

        [XmlAttribute]
        public bool TwoTailed { get; set; }
    }
}
