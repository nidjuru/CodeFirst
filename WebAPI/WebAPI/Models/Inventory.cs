using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
       
        [Required]
        [ForeignKey("BookId")]
        public int BookId { get; set; }
        public List<Book> Books { get; set; }
        [Required]
        [ForeignKey("RentalId")]
        public int RentalId { get; set; }
        public List<Rental> Rentals { get; set; }
        public bool Available
        {
            get
            {
                if (Rentals == null)
                {
                    return true;
                }
                else if (Rentals.Count == 0)
                {
                    return true;
                }
                else if (Rentals.All(r => r.Returned))
                {
                    return true;
                }

                return true;
            }

        }
    }
}
