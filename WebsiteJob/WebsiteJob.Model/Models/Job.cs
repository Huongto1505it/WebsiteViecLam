namespace WebsiteJob.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            Tags = new HashSet<Tag>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(250)]
        public string Alas { get; set; }

        public int CategoryID { get; set; }

        public int? Warranty { get; set; }

        public string Content { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? DisplayOrder { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(250)]
        public string MetaKeyword { get; set; }

        [StringLength(250)]
        public string MetaDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string Createdby { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string Updatedby { get; set; }

        public bool Status { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        public virtual JobCategory JobCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
