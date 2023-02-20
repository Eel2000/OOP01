﻿namespace MyBank.Models
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Password { get; set; }
    }
}
