﻿using System;
namespace DentalCare.Models
{
	public class Patient
	{
        public int Id { get; set; }
        public string? Personnummer { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

    }
}

