using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    class Reservation
    {
        [Key]
        public int ID { get; private set; }
        [Required]
        public Room Room { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public IEnumerable<Customer> Customers{ get; set; }
        [Required]
        public string DateOfAccommodation { get; set; }
        [Required]
        public string ReleaseDate { get; set; }
        [Required]
        public bool IncludedBreakfast { get; set; }
        [Required]
        public bool AllInclusive { get; set; }
        [Required]
        public double Price { get; set; }
        
        [ForeignKey("Room")]
        public int RoomNumber { get; set; }
        [ForeignKey("User")]
        public int UserPIN { get; set; }
        private Reservation()
        {
                
        }

        public Reservation(Room room, User user, string dateOfAccommodation, string releaseDate, bool includedBreakfast, bool allInclusive, double price)
        {
            Room = room;
            User = user;
            DateOfAccommodation = dateOfAccommodation;
            ReleaseDate = releaseDate;
            IncludedBreakfast = includedBreakfast;
            AllInclusive = allInclusive;
            Price = price;
        }
    }
}
