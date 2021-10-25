namespace Cinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POST")]
    public partial class POST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POST()
        {
            POST_CONTENT = new HashSet<POST_CONTENT>();
        }

        [StringLength(10)]
        public string PostID { get; set; }

        [StringLength(30)]
        public string PostCategory { get; set; }

        [StringLength(100)]
        public string PostThumbnail { get; set; }

        [Column(TypeName = "ntext")]
        public string PostTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string PostDescription { get; set; }

        public DateTime? CreateAt { get; set; }

        [StringLength(10)]
        public string AdminID { get; set; }

        public virtual ADMIN_ACCOUNT ADMIN_ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST_CONTENT> POST_CONTENT { get; set; }
    }
}
