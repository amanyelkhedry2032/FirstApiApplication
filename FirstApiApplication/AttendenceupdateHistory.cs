//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstApiApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendenceupdateHistory
    {
        public int AttendenceupdateHistoryId { get; set; }
        public int AttendenceId { get; set; }
        public System.DateTime DatetimeHistory { get; set; }
        public int EmployeeId { get; set; }
        public int Type { get; set; }
        public Nullable<System.DateTime> OriginalTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    
        public virtual Attendence Attendence { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
