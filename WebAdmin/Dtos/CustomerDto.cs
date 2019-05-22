using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double MoneyAccount { get; set; }
        public string FullName { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public string Avatar { get; set; }
    }
}
