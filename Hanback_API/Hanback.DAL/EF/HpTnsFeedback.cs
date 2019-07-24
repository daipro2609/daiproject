using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpTnsFeedback
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? ReplyYn { get; set; }
        public DateTime? ReplyTime { get; set; }
        public string ReplyBy { get; set; }
        public string ReplyMessage { get; set; }
        public string Category { get; set; }
    }
}
