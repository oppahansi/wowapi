﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Classic
{
    [Table("gameobject_questrelation")]
    public class CGameObjectQuestrelation : IEntity
    {
        [Key]
        public uint Id { get; set; }
        [Key]
        public uint Quest { get; set; }
    }
}