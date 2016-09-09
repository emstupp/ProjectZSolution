using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ZPRO.Model
{
    [XmlRoot]
    public class Sample
    {

        [XmlIgnore]
        public int SampleID { get; set; }

        [XmlAttribute]
        public double PopulationMean { get; set; }

        [XmlIgnore]
        public int StatisticID { get; set; }

        [XmlAttribute]
        public double SampleMean { get; set; }

        [XmlAttribute]
        public double SampleStDev { get; set; }

        [XmlAttribute]
        public int SampleSize { get; set;}
        
    }
}
