namespace TeduShop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MenuGroup
    {
        public MenuGroup()
        {
            Menus = new HashSet<Menu>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
