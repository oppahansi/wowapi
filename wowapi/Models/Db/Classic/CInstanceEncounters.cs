﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("instance_encounters")]
    public class CInstanceEncounters
    {
        [Key]
        public uint Entry { get; set; }
        public byte CreditType { get; set; }
        public uint CreditEntry { get; set; }
        public ushort LastEncounterDungeon { get; set; }
    }
}
