namespace TeduShop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Tag
    {
        public Tag()
        {
            Posts = new HashSet<Post>();
            Products = new HashSet<Product>();
        }

        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
