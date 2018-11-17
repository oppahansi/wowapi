﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("creature_equip_template")]
    public class CCreatureEquipTemplate : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public uint Equipentry1 { get; set; }
        public uint Equipentry2 { get; set; }
        public uint Equipentry3 { get; set; }
    }
}
