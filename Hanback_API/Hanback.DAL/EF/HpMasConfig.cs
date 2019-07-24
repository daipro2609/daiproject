using System;
using System.Collections.Generic;

namespace Hanback.DAL.EF
{
    public partial class HpMasConfig
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creator { get; set; }
        public string Changer { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
