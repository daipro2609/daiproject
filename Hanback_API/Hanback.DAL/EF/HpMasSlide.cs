using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasSlide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public int DisplayOrder { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public int SlideType { get; set; }
        public bool UseYn { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creator { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
