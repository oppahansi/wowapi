﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("spell_proc_item_enchant")]
    public class CSpellProcItemEnchant : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public float PpmRate { get; set; }
    }
}