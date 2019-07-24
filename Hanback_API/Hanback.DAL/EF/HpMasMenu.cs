using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasMenu
    {
        public int MenuId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int? DisplayOrder { get; set; }
        public string Link { get; set; }
        public int MenuType { get; set; }
        public bool UseYn { get; set; }
        public string Remarks { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangTime { get; set; }
    }
}
