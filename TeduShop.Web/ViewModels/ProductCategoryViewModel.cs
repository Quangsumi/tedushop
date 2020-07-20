using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Web.ViewModels
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? DisplayOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        //public virtual ICollection<ProductViewModel> Products { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }
        
        [Required]
        public bool Status { get; set; }
    }
}