﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Common
{
    public class PetNameGenerationBase : IEntity
    {
        [Key]
        public uint Id { get; set; }
        public string Word { get; set; }
        public uint Entry { get; set; }
    }
}
