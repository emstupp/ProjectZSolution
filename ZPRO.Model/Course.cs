using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPRO.Model
{
    public class Course
    {
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public string Department { get; set; }
        public int SectionNum { get; set; }
        public string Title { get; set; }
        public string Days { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Professor { get; set; }
        public int Credits { get; set; }

    }
}
