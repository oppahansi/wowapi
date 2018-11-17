﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("pet_familystats")]
    public class CPetFamilyStats : IEntity
    {
        [Key]
        public uint Family { get; set; }
        public float HealthModifier { get; set; }
        public float DamageModifier { get; set; }
        public float ArmorModifier { get; set; }
    }
}
