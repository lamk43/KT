namespace KT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenGoi")]
    public partial class TenGoi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("TenGoi")]
        [StringLength(50)]
        public string TenGoi1 { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Sodienthoai { get; set; }

        public int? ID_Nhom { get; set; }

        public virtual TenNhom TenNhom { get; set; }
    }
}
