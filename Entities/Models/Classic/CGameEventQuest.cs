﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("game_event_quest")]
    public class CGameEventQuest : IEntity
    {
        [Key]
        public uint Quest { get; set; }
        [Key]
        public ushort Event { get; set; }
    }
}
