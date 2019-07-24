using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasComment
    {
        public int CommentId { get; set; }
        public int ArticleId { get; set; }
        public int MemberId { get; set; }
        public string Username { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creator { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
