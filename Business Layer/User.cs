using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    class User
    {
        [Key, Required]
        public int PIN { get; private set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string FathersName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DateOfAppointment { get; set; }
        [Required]
        public bool AccountActivity { get; set; }
        public string ReleaseDate { get; set; }

        private User()
        {

        }

        public User(string username, string password, string firstName, string fathersName, string surname, string phoneNumber, string email, string dateOfAppointment, bool accountActivity, string releaseDate)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            FathersName = fathersName;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            DateOfAppointment = dateOfAppointment;
            AccountActivity = accountActivity;
            ReleaseDate = releaseDate;
        }
    }
}
