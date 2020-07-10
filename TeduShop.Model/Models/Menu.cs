namespace TeduShop.Model.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Menu
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupId { get; set; }

        [MaxLength(10)]
        public string Target { get; set; }

        public bool Status { get; set; }

        public virtual MenuGroup MenuGroup { get; set; }
    }
}
