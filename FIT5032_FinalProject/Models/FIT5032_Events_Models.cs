using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_FinalProject.Models
{
    public partial class FIT5032_Events_Models : DbContext
    {
        public FIT5032_Events_Models()
            : base("name=FIT5032_Events_Models")
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}
