﻿using MacroTest.Models;
using System;
using System.Threading;

namespace MacroTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LeftMouseClick(0, 0);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSE_LEFTDOWN = 0x02;
        public const int MOUSE_LEFTUP = 0x04;

        public static void LeftMouseClick(int x, int y)
        {
            SetCursorPos(x, y);
            HarvestArea harvestArea = new HarvestArea();
            harvestArea.LeftPointWallSide = new System.Drawing.Point(x, y);
            harvestArea.LeftPointStreetSide = new System.Drawing.Point(x, y+300);
            harvestArea.RightPointStreetSide = new System.Drawing.Point(x + 300, y + 300);
            harvestArea.RightPointWallSide = new System.Drawing.Point(x + 300, y);

            //mouse_event(MOUSE_LEFTDOWN, x, y, 0, 0);
            //mouse_event(MOUSE_LEFTUP, x, y, 0, 0);
            do
            {
                SetCursorPos(x, y);

            } while (true);

        }
    }
}
