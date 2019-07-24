using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasCategory
    {
        public int CategoryId { get; set; }
        public int ParentId { get; set; }
        public string CateName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool UseYn { get; set; }
        public bool IsMenu { get; set; }
        public bool IsSystem { get; set; }
        public string UrlRewrite { get; set; }
        public string PageLink { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public string Remarks { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }
        public string Attr4 { get; set; }
        public string Attr5 { get; set; }
    }
}
