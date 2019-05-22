using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
    }
}
