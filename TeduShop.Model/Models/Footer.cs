namespace TeduShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Footer
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}