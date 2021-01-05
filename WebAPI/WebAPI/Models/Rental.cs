using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public Inventory Inventory { get; set; }
        [Required]
        public int InventoryId { get; set; }
        public DateTime? RentalDate { get; set; }//Även fast det är nullable här, så sköter controllern inmatningen automatiskt
        public DateTime? ReturnDate { get; set; }
        public bool Rented { get; set; } = false;//Kolla ifall denna är överflödig!!!!!!!!!!!!!!!!!!!!!
        public Customer Customer{ get; set; }
        [Required]
        public int CustomerId { get; set; }
        public bool Returned
        {
            get
            {
                return ReturnDate == null ? false : true;
            }
        }
    }
}
