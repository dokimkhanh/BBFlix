namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieType")]
    public partial class MovieType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovieType()
        {
            Movie = new HashSet<Movie>();
        }

        [Key]
        public int mov_type_id { get; set; }

        [StringLength(100)]
        public string mov_type_title { get; set; }

        [StringLength(100)]
        public string mov_type_slug { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie> Movie { get; set; }
    }
}
