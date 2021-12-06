using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace InspectorsApp.Models
{
    public partial class database : DbContext
    {
        public database()
            : base("name=database")
        {
        }

        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
