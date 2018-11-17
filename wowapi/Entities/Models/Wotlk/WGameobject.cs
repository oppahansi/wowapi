﻿using wowapi.Entities.Models.Common;

namespace wowapi.Entities.Models.Wotlk
{
    public class WGameobject : GameObjectBase
    {
        public ushort ZoneId { get; set; }
        public ushort AreaId { get; set; }
        public byte SpawnMask { get; set; }
        public uint PhaseMask { get; set; }
        public int Spawntimesecs { get; set; }
        public string ScriptName { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
