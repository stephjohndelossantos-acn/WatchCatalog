using System.ComponentModel.DataAnnotations;

namespace WatchCatalog.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string WatchName { get; set; } = string.Empty;

        [Required]
        [StringLength(60)]
        public string Brand { get; set; } = string.Empty;

        [Range(0, 1000000000)]
        public decimal Price { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; } = 1;

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; } = DateTime.Today;
    }
}
