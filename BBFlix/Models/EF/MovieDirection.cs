namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieDirection")]
    public partial class MovieDirection
    {
        public int id { get; set; }

        public int dir_id { get; set; }

        public int mov_id { get; set; }

        public virtual Director Director { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
