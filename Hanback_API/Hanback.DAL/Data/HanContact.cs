using System;
using System.Collections.Generic;
using System.Text;

namespace Hanback.DAL.Data
{
    public class HanContact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Message { get; set; }

        public string Remark { get; set; }
         
        public bool? REPLY_YN { get; set; }

        public DateTime? Created_time { get; set; }

        public string Category { get; set;  }
    }
}
