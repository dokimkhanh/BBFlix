namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieData")]
    public partial class MovieData
    {
        public int id { get; set; }

        public int? mov_id { get; set; }

        [StringLength(100)]
        public string chap_name { get; set; }

        public string mov_link { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
