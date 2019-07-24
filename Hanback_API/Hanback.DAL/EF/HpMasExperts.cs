using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasExperts
    {
        public int EmployeesId { get; set; }
        public string Position { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public bool Active { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creator { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
