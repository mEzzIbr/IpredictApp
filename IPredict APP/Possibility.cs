//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPredict_APP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Possibility
    {
        public int P_ID { get; set; }
        public string MatchID { get; set; }
        public Nullable<double> W1 { get; set; }
        public Nullable<double> W2 { get; set; }
    
        public virtual Match_level Match_level { get; set; }
    }
}
