﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPRO.Model
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int CourseID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
    }
}
