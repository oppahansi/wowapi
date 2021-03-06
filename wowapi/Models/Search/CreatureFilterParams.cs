namespace wowapi.Models.Search
{
    public class CreatureFilterParams : FilterParams
    {
        public string Name { get; set; } = null;
        public string SubName { get; set; } = null;
        public byte MinLevel { get; set; } = 0;
        public byte MaxLevel { get; set; } = 0;
        public sbyte Family { get; set; } = 0;
        public byte Type { get; set; } = 100;
        public uint NpcFlags { get; set; } = 0;
        public uint ExtraFlags { get; set; } = 0;
        public uint MechanicImmuneMask { get; set; } = 0;
        public uint SchoolImmuneMask { get; set; } = 0;
        public byte Civilian { get; set; } = 2;
    }
}