using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTimeOffset DateAdded { get; set; }

        public DateTimeOffset? DateUpdated { get; set; }
    }
}
