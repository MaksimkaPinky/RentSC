using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RentSC
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Аренда> Аренда { get; set; }
        public virtual DbSet<Арендаторы> Арендаторы { get; set; }
        public virtual DbSet<Павильоны> Павильоны { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<ТЦ> ТЦ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Арендаторы>()
                .HasMany(e => e.Аренда)
                .WithRequired(e => e.Арендаторы)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Павильоны>()
                .Property(e => e.Стоимость_за_кв__м_)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Сотрудники>()
                .HasMany(e => e.Аренда)
                .WithRequired(e => e.Сотрудники)
                .HasForeignKey(e => e.ID_сотрудника)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ТЦ>()
                .Property(e => e.Стоимость)
                .HasPrecision(19, 4);
        }
    }
}
