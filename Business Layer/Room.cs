using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    class Room
    {
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool AvailabeRoom { get; set; }
        [Required]
        public double AdultsBedPrice { get; set; }
        [Required]
        public double ChildsBedPrice { get; set; }
        [Key,Required]
        public int Number { get; private set; }
        private Room()
        {

        }

        public Room(int capacity, int type, bool availabeRoom, int adultsBedPrice, int childsBedPrice)
        {
            Capacity = capacity;
            Type = type;
            AvailabeRoom = availabeRoom;
            AdultsBedPrice = adultsBedPrice;
            ChildsBedPrice = childsBedPrice;
        }
    }
}
