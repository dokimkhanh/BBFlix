namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reviewer")]
    public partial class Reviewer
    {
        [Key]
        public int rev_id { get; set; }

        public int mov_id { get; set; }

        [Required]
        [StringLength(150)]
        public string rev_content { get; set; }

        public double rev_star { get; set; }

        public int rev_by { get; set; }

        public DateTime rev_date { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual User User { get; set; }
    }
}
