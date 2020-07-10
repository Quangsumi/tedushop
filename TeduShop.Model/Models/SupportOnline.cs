namespace TeduShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class SupportOnline
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Department { get; set; }

        [StringLength(250)]
        public string Skype { get; set; }

        [StringLength(250)]
        public string Mobile { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Yahoo { get; set; }

        [StringLength(250)]
        public string Facebook { get; set; }

        public bool Status { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
