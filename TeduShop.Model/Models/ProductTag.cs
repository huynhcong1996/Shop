using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public int TagID { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}
