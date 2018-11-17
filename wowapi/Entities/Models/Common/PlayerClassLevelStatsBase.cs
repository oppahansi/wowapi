﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Common
{
    [Table("player_classlevelstats")]
    public class PlayerClassLevelStatsBase : IEntity
    {
        [Key]
        public byte Class { get; set; }
        [Key]
        public byte Level { get; set; }
        public ushort Basehp { get; set; }
        public ushort Basemana { get; set; }
    }
}
