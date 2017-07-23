//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecordsDataModel.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mrecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mrecord()
        {
            this.Genres = new HashSet<Genre>();
            this.Tracks = new HashSet<Track>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ArtistId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Title { get; set; }
        public Nullable<int> ReleaseID { get; set; }
        public Nullable<int> LabelId { get; set; }
        public Nullable<int> FormatID { get; set; }
        public Nullable<int> GenreID { get; set; }
        public string ReleaseMonth { get; set; }
        public string ReleaseYear { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Country Country { get; set; }
        public virtual Format Format { get; set; }
        public virtual Label Label { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genre> Genres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
