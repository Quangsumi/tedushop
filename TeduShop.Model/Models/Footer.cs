namespace TeduShop.Model.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Footer
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}