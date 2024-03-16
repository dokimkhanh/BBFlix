namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Actor")]
    public partial class Actor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actor()
        {
            MovieCast = new HashSet<MovieCast>();
        }

        [Key]
        public int act_id { get; set; }

        [StringLength(250)]
        public string act_name { get; set; }

        public int? act_gender { get; set; }

        [StringLength(250)]
        public string act_slug { get; set; }

        [StringLength(100)]
        public string act_avatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieCast> MovieCast { get; set; }
    }
}
