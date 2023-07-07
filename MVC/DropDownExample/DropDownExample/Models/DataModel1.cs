using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

namespace DropDownExample.Models
{
    public partial class DataModel1 : DbContext
    {
        public DataModel1()
            : base("name=DataModel1")
        {
        }

 

        public virtual DbSet<StateTable> StateTables { get; set; }
        public virtual DbSet<CityTable> CityTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateTable>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<CityTable>()
                .Property(e => e.CityName)
                .IsUnicode(false);
        }
    }
}
