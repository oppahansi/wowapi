﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("")]
    public class CLocalesQuestgiverGreeting
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Type { get; set; }
        public string TextLoc1 { get; set; }
        public string TextLoc2 { get; set; }
        public string TextLoc3 { get; set; }
        public string TextLoc4 { get; set; }
        public string TextLoc5 { get; set; }
        public string TextLoc6 { get; set; }
        public string TextLoc7 { get; set; }
        public string TextLoc8 { get; set; }
    }
}
