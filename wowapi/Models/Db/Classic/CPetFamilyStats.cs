﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Models.Db.Classic
{
    [Table("pet_familystats")]
    public class CPetFamilyStats
    {
        [Key]
        public uint Family { get; set; }
        public float HealthModifier { get; set; }
        public float DamageModifier { get; set; }
        public float ArmorModifier { get; set; }
    }
}
