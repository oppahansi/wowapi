﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("spell_elixir")]
    public class CSpellElixir : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public byte Mask { get; set; }
    }
}