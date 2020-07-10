namespace TeduShop.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class VisitorStatistic
    {
        public int Id { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }
    }
}
