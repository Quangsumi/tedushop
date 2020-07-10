namespace TeduShop.Model.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TeduShop.Model.Abstract;

    public partial class ProductCategory : Auditable
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? DisplayOrder { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
