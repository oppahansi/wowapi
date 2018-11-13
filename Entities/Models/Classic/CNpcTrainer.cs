﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("npc_trainer")]
    public class CNpcTrainer : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        [Key]
        public uint Spell { get; set; }
        public uint Spellcost { get; set; }
        public ushort Reqskill { get; set; }
        public ushort Reqskillvalue { get; set; }
        public byte Reqlevel { get; set; }
        public uint ConditionId { get; set; }
    }
}
