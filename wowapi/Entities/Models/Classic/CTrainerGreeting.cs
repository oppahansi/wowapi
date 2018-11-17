﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wowapi.Entities.Models.Classic
{
    [Table("trainer_greeting")]
    public class CTrainerGreeting : IEntity
    {
        [Key]
        public uint Entry { get; set; }
        public string Text { get; set; }
    }
}
