//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirAtlantique
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session
    {
        public Session()
        {
            this.Employes_Sessions = new HashSet<Employes_Sessions>();
        }
    
        public int idSession { get; set; }
        public string nom { get; set; }
        public System.DateTime date { get; set; }
        public int duree { get; set; }
        public Nullable<int> nbPlace { get; set; }
        public int idFormation { get; set; }
    
        public virtual ICollection<Employes_Sessions> Employes_Sessions { get; set; }
        public virtual Formation Formation { get; set; }
    }
}
