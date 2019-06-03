﻿namespace Navigator.DAL.SDE
{
    public partial class MapRegions
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }
        public double? XMin { get; set; }
        public double? XMax { get; set; }
        public double? YMin { get; set; }
        public double? YMax { get; set; }
        public double? ZMin { get; set; }
        public double? ZMax { get; set; }
        public int? FactionId { get; set; }
        public double? Radius { get; set; }
    }
}
