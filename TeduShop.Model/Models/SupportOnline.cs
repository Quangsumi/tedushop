namespace TeduShop.Model.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class SupportOnline
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Department { get; set; }

        [MaxLength(250)]
        public string Skype { get; set; }

        [MaxLength(250)]
        public string Mobile { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Yahoo { get; set; }

        [MaxLength(250)]
        public string Facebook { get; set; }

        public bool Status { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
