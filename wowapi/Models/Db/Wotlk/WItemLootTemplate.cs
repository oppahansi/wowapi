﻿using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Wotlk
{
    public class WItemLootTemplate : ItemLootTemplateBase
    {
        public uint Reference { get; set; }
        public float Chance { get; set; }
        public sbyte QuestRequired { get; set; }
        public ushort LootMode { get; set; }
        public byte MinCount { get; set; }
        public byte MaxCount { get; set; }
        public string Comment { get; set; }
    }
}
