namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Director")]
    public partial class Director
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Director()
        {
            MovieDirection = new HashSet<MovieDirection>();
        }

        [Key]
        public int dir_id { get; set; }

        [Required]
        [StringLength(250)]
        public string dir_name { get; set; }

        [Required]
        [StringLength(250)]
        public string dic_slug { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieDirection> MovieDirection { get; set; }
    }
}
