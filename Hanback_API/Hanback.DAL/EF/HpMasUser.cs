using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasUser
    {
        public int UserId { get; set; }
        public int? RoleId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool UseYn { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creator { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
