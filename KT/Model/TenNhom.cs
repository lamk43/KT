namespace KT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenNhom")]
    public partial class TenNhom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TenNhom()
        {
            TenGois = new HashSet<TenGoi>();
        }

        public int ID { get; set; }

        [Column("TenNhom")]
        [StringLength(50)]
        public string TenNhom1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenGoi> TenGois { get; set; }
    }
}
