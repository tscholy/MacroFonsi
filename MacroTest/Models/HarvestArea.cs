using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;

namespace MacroTest.Models
{
    public  class HarvestArea
    {
        private Point leftPointStreetSide;
        private Point rightPointStreetSide;

        private Point leftPointWallSide;
        private Point rightPointWallSide;

        public HarvestArea()
        {
            
        }

        public Point LeftPointStreetSide { get => leftPointStreetSide; set => leftPointStreetSide = value; }
        public Point RightPointStreetSide { get => rightPointStreetSide; set => rightPointStreetSide = value; }
        public Point LeftPointWallSide { get => leftPointWallSide; set => leftPointWallSide = value; }
        public Point RightPointWallSide { get => rightPointWallSide; set => rightPointWallSide = value; }
    }
}
