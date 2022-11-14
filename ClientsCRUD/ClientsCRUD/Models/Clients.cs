using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClientsCRUD.Models
{
	public class Clients
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        [Required]
        public string PhoneNumber { get; set; } = "";

        public string Email { get; set; } = ""; 
    }
}

