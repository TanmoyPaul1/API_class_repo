using System;
namespace MyFirstAPI.Models
{
    public class Email
    {
        public int? EmailID { get; set; }
        public string? EmailAddress { get; set; }
        public bool? IsSubscribed { get; set; }
    }
}
