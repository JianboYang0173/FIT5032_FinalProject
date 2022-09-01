using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_FinalProject.Models
{
    public partial class FIT5032_Disease_Models : DbContext
    {
        public FIT5032_Disease_Models()
            : base("name=FIT5032_Disease_Models")
        {
        }

        public virtual DbSet<Disease> Diseases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
