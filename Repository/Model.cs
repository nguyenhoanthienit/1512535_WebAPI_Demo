using _1512535_BaiTapAPI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository
{
    public class Model : DbContext
    {
        public Model(): base("name=DatPhongConnection")
        {
            Database.SetInitializer<Model>(new CreateDatabaseIfNotExists<Model>());
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<DatPhong> DatPhong { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>().Property(e => e.MaKH);
            modelBuilder.Entity<Phong>().Property(e => e.MaPhong);
            modelBuilder.Entity<DatPhong>().Property(e => e.MaDatPhong);                       
        }
    }
}