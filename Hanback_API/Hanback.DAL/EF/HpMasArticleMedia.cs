using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasArticleMedia
    {
        public int MediaId { get; set; }
        public int ArticleId { get; set; }
        public int? MediaType { get; set; }
        public string Link { get; set; }
        public string Remarks { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
