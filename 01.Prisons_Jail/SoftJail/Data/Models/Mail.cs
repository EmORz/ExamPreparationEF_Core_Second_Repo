﻿using System.ComponentModel.DataAnnotations;

namespace SoftJail.Data.Models
{
    public class Mail
    {
        //    •	Id – integer, Primary Key
        //•	Description– text(required)
        //•	Sender – text(required)
        //•	Address – text, consisting only of letters, spaces and numbers, which ends with “ str.” (required) (Example: “62 Muir Hill str.“)
        //•	PrisonerId - integer, foreign key
        //•	Prisoner – the mail's Prisoner (required)

        public Mail(string description, string address, string sender)
        {
            this.Description = description;
            this.Address = address;
            this.Sender = sender;
        }

        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        [RegularExpression("([A-Za-z 0-9]+ str.?)")]
        public string Address { get; set; } // todo regular expresion

        public int PrisonerId { get; set; }
        [Required]
        public Prisoner Prisoner { get; set; }


    }
}