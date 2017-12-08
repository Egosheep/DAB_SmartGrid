using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace SQL_Infrastructure_Library.Entities
{
    public class ProsumerContext : DbContext
    {
        public ProsumerContext() : base(String.Empty)
        {
            
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Prosumer> Prosumers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            /*modelBuilder.Entity<Prosumer>()
                .Property(u => u.PersonId)
                .HasColumnName("Prosumers");*/
        }
    }
}