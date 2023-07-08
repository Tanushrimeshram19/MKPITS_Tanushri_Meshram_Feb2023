using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DropDownproduct.Models
{
    public partial class DataModel1 : DbContext
    {
        public DataModel1()
            : base("name=DataModel1")
        {
        }
        public virtual DbSet<TableProduct> TableProduct{ get; set; }
        public virtual DbSet<TableCategory>TableCategory { get; set; }


        public virtual DbSet<TableProduct> TableProducts { get; set; }
        public virtual DbSet<TableCategory> TableCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
