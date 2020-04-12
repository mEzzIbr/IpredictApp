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
    
    public partial class Match_level
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Match_level()
        {
            this.Possibilities = new HashSet<Possibility>();
        }
    
        public Nullable<double> HomeScore { get; set; }
        public Nullable<double> AwayScore { get; set; }
        public string HomeTeamID { get; set; }
        public string AwayTeamID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> HomeFoulCommited { get; set; }
        public Nullable<double> AwayFoulCommited { get; set; }
        public Nullable<double> HomeYellowCard { get; set; }
        public Nullable<double> AwayYellowCard { get; set; }
        public Nullable<double> HomeRedCard { get; set; }
        public Nullable<double> AwayRedCard { get; set; }
        public Nullable<double> HomeSave { get; set; }
        public Nullable<double> AwaySaves { get; set; }
        public Nullable<double> StadiumID { get; set; }
        public Nullable<double> Attendance { get; set; }
        public string Match_ID { get; set; }
        public string leagueid { get; set; }
        public Nullable<System.DateTime> F18 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Possibility> Possibilities { get; set; }
    }
}