﻿using System;
using Entities.Models.Common;

namespace Entities.Models.Wotlk
{
    public class WPointsOfInterest : PointsOfInterestBase
    {
        public uint Id { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public uint Importance { get; set; }
        public string Name { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
