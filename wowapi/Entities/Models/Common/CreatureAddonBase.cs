﻿using System;
using System.ComponentModel.DataAnnotations;

namespace wowapi.Entities.Models.Common
{
    public class CreatureAddonBase : IEntity
    {
        [Key]
        public uint Guid { get; set; }
        public uint Mount { get; set; }
        public uint Bytes1 { get; set; }
        public uint Emote { get; set; }
        public string Auras { get; set; }
    }
}