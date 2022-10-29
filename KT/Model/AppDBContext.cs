using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KT.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

        public virtual DbSet<TenGoi> TenGois { get; set; }
        public virtual DbSet<TenNhom> TenNhoms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenNhom>()
                .HasMany(e => e.TenGois)
                .WithOptional(e => e.TenNhom)
                .HasForeignKey(e => e.ID_Nhom);
        }
    }
}
