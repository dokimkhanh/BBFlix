namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieCast")]
    public partial class MovieCast
    {
        public int id { get; set; }

        public int act_id { get; set; }

        public int movie_id { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
