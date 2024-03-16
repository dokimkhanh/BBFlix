namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MovieGenres
    {
        public int id { get; set; }

        public int? mov_id { get; set; }

        public int? gen_id { get; set; }

        public virtual Genres Genres { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
