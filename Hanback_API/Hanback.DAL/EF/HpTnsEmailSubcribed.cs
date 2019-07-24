using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpTnsEmailSubcribed
    {
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Mobile { get; set; }
        public string Title { get; set; }
        public bool? UseYn { get; set; }
        public string Remarks { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
        public DateTime? UnsubcribedDate { get; set; }
        public string UnsubcribedMessage { get; set; }
    }
}
