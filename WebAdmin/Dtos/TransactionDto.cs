using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public double Value { get; set; }
        public DateTime InputDate { get; set; }
        public string Status { get; set; }
        public int TransactionTypeId { get; set; }
    }
}
