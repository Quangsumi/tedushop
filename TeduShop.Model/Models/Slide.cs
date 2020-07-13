namespace TeduShop.Model.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Slide
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string Image { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        public int? DisplayOrder { get; set; }

        public bool Status { get; set; }
    }
}
