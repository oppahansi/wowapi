﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("conditions")]
    public class CConditions
    {
        [Key]
        public uint ConditionEntry { get; set; }
        public sbyte Type { get; set; }
        public uint Value1 { get; set; }
        public uint Value2 { get; set; }
        public string Comments { get; set; }
    }
}
