//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WWWBewertungPortal.Models.Datenbank
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tab_Bewertung
    {
        public Tab_Bewertung()
        {
            this.Tab_Lokation_Photo = new HashSet<Tab_Lokation_Photo>();
            this.Tab_Kommentar = new HashSet<Tab_Kommentar>();
        }
    
        public int Id { get; set; }
        public string Ueberschrift { get; set; }
        public string Inhalt { get; set; }
        public string Erstelltlungdatum { get; set; }
        public string Voting { get; set; }
    
        public virtual Tab_Lokation Tab_Lokation { get; set; }
        public virtual Tab_Benutzer Tab_Benutzer { get; set; }
        public virtual ICollection<Tab_Lokation_Photo> Tab_Lokation_Photo { get; set; }
        public virtual ICollection<Tab_Kommentar> Tab_Kommentar { get; set; }
    }
}
