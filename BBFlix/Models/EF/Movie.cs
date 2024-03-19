namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            MovieCast = new HashSet<MovieCast>();
            MovieData = new HashSet<MovieData>();
            MovieDirection = new HashSet<MovieDirection>();
            MovieGenres = new HashSet<MovieGenres>();
            Reviewer = new HashSet<Reviewer>();
        }

        [Key]
        public int mov_id { get; set; }

        [Required]
        [StringLength(150)]
        public string mov_title { get; set; }

        [Required]
        public string mov_dec { get; set; }

        public int mov_year { get; set; }

        public int mov_country { get; set; }

        [Column(TypeName = "date")]
        public DateTime mov_date_rel { get; set; }

        [Required]
        [StringLength(200)]
        public string mov_thumb { get; set; }

        public long mov_time { get; set; }

        [Required]
        [StringLength(150)]
        public string mov_slug { get; set; }

        public bool mov_status { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieCast> MovieCast { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieData> MovieData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieDirection> MovieDirection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieGenres> MovieGenres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviewer> Reviewer { get; set; }
    }
}
