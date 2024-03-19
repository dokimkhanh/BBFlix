namespace BBFlix.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Reviewer = new HashSet<Reviewer>();
        }

        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(150)]
        public string user_fullname { get; set; }

        [Required]
        [StringLength(100)]
        public string user_email { get; set; }

        public string user_avatar { get; set; }

        [Required]
        [StringLength(50)]
        public string user_pass { get; set; }

        public int user_plan { get; set; }

        public bool user_status { get; set; }

        public int user_role { get; set; }

        public virtual Plan Plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviewer> Reviewer { get; set; }
    }
}
