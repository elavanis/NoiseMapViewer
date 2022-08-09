using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseMapViewer
{
    public class Settings
    {
        public string RootFolder { get; set; } = @"\\10.1.0.5\Vol1\Data\DndMaps";
        public int Tiles { get; set; } = 3;
        public int PositionX { get; set; } = 1;
        public int PositionY { get; set; } = 1;
        public string TileSize { get; set; } = "1000-1000";
        public decimal Zoom { get; set; } = 10000.0m;
        public int Seed { get; set; } = 2;
    }
}
