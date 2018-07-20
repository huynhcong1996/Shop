namespace TeduShop.Model.Models1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Foodter
    {
        [StringLength(250)]
        public string ID { get; set; }

        public string Content { get; set; }
    }
}
