﻿using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TAreatriggerTeleport : AreatriggerTeleportBase
    {
        public byte RequiredLevel { get; set; }
        public uint RequiredItem { get; set; }
        public uint RequiredItem2 { get; set; }
        public uint HeroicKey { get; set; }
        public uint HeroicKey2 { get; set; }
        public uint RequiredQuestDone { get; set; }
        public uint RequiredQuestDoneHeroic { get; set; }
        public uint ConditionId { get; set; }
        public byte Status { get; set; }
        public string StatusFailedText { get; set; }
    }
}
