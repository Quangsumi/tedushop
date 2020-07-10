namespace TeduShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SystemConfig
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }

        [StringLength(250)]
        public string ValueString { get; set; }

        public int? ValueInt { get; set; }
    }
}
