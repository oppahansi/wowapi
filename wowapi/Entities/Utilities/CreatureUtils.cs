﻿using wowapi.Entities.Enumerations;
using System.Collections.Generic;
using wowapi.Entities.Dictionaries;

namespace Utilities
{
    public static class CreatureUtils
    {
        public static IEnumerable<string> BreakDownExtraFlags(uint extraFlags)
        {
            var extraFlagsList = new List<string>();
            var extraFlagEnumValues = EnumUtil.GetValues<CreatureEnums.CreatureExtraFlags>();

            foreach (var extraFlag in extraFlagEnumValues)
            {
                if ((extraFlags & (uint)extraFlag) == (uint)extraFlag)
                    extraFlagsList.Add(CreatureDictionary.ExtraFlags[(uint)extraFlag]);
            }

            return extraFlagsList;
        }

    }
}