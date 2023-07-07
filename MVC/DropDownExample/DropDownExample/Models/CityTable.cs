namespace DropDownExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CityTable")]
    public partial class CityTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        public int? StateId { get; set; }

        public virtual StateTable StateTable { get; set; }
    }
}
