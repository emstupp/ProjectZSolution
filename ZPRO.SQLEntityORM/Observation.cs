//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZPRO.SQLEntityORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Observation
    {
        public int ObservationID { get; set; }
        public int SampleID { get; set; }
        public double obs { get; set; }
    
        public virtual Sample Sample { get; set; }
    }
}
