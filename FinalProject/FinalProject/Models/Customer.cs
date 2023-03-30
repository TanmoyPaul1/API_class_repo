using System;
namespace FinalProject.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public List<Email>? Emails { get; set; }
    }
}
