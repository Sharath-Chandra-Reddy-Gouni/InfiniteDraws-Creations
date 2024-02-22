using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InfiniteDraws_Creations.Models
{
    public class Drawer
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public String? Type { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? DrawerMaterial { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Color { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public Decimal Rating { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(30)]
        [Required]
        public string? Reviews { get; set; }



    }
}
