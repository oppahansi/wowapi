﻿using System.ComponentModel.DataAnnotations.Schema;
using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Classic
{
    [Table("fishing_loot_template")]
    public class CFishingLootTemplate : FishingLootTemplateBase
    {
        public float ChanceOrQuestChance { get; set; }
        public int MincountOrRef { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; }
    }
}
