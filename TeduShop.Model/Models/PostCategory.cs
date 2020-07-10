namespace TeduShop.Model.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TeduShop.Model.Abstract;

    public partial class PostCategory : Auditable
    {
        public PostCategory()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Alias { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
