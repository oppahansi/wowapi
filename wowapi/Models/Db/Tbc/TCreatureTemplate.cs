﻿using wowapi.Models.Db.Common;

namespace wowapi.Models.Db.Tbc
{
    public class TCreatureTemplate : CreatureTemplateBase
    {
        public string IconName { get; set; }
        public uint HeroicEntry { get; set; }
        public ushort FactionAlliance { get; set; }
        public ushort FactionHorde { get; set; }
        public byte CreatureType { get; set; }
        public byte RegenerateStats { get; set; }
        public uint NpcFlags { get; set; }
        public uint ExtraFlags { get; set; }
        public uint CreatureTypeFlags { get; set; }
        public uint Detection { get; set; }
        public uint CallForHelp { get; set; }
        public uint Pursuit { get; set; }
        public uint Leash { get; set; }
        public uint Timeout { get; set; }
        public sbyte Expansion { get; set; }
        public float HealthMultiplier { get; set; }
        public float PowerMultiplier { get; set; }
        public float DamageMultiplier { get; set; }
        public float DamageVariance { get; set; }
        public float ArmorMultiplier { get; set; }
        public float ExperienceMultiplier { get; set; }
        public uint MinLevelHealth { get; set; }
        public uint MaxLevelHealth { get; set; }
        public uint MinLevelMana { get; set; }
        public uint MaxLevelMana { get; set; }
        public float MinMeleeDmg { get; set; }
        public float MaxMeleeDmg { get; set; }
        public float MinRangedDmg { get; set; }
        public float MaxRangedDmg { get; set; }
        public uint Armor { get; set; }
        public uint MeleeAttackPower { get; set; }
        public ushort RangedAttackPower { get; set; }
        public uint MeleeBaseAttackTime { get; set; }
        public uint RangedBaseAttackTime { get; set; }
        public sbyte DamageSchool { get; set; }
        public uint MinLootGold { get; set; }
        public uint MaxLootGold { get; set; }
        public uint PickpocketLootId { get; set; }
        public uint SkinningLootId { get; set; }
        public uint SchoolImmuneMask { get; set; }
        public short ResistanceHoly { get; set; }
        public short ResistanceFire { get; set; }
        public short ResistanceNature { get; set; }
        public short ResistanceFrost { get; set; }
        public short ResistanceShadow { get; set; }
        public short ResistanceArcane { get; set; }
        public uint TrainerTemplateId { get; set; }
        public uint VendorTemplateId { get; set; }
        public uint EquipmentTemplateId { get; set; }
    }
}
