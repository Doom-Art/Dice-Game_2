using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Die
    {
        private Random _generator;
        private int _roll;
        private int _sides;
        public Die()
        {
            _generator = new Random();
            _sides = 6; 
            _roll = _generator.Next(1, _sides+1);
        }
        public Die(int roll)
        {
            _generator = new Random();
            _sides = 6;
            if (roll < 0 || roll > 6)
                roll = _generator.Next(1, _sides+1);
            _roll = roll;
        }
        public Die (int sides, int roll)
        {
            _generator = new Random();
            if (sides < 2 || sides > 9)
                sides = 6;
            _sides = sides;
            if (roll < 0 || roll > sides)
                roll = _generator.Next(1,sides+1);
            _roll = roll;
        }
        public int Roll
        {
            get { return _roll; }
        }
        public override string ToString()
        {
            return _roll.ToString();
        }
        public void RollDie()
        {
            _roll = _generator.Next(1,_sides+1);
        }
        /// <summary>
        /// Draws the current face of the die based on the provided x,y coordinates
        /// </summary>
        /// <param name="x">The X position you would like the dice drawing to begin</param>
        /// <param name="y">The Y position you would like the dice drawing to begin</param>
        public void DrawDie(int x, int y)
        {
            switch (_roll)
            {
                case 1:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|   |");
                    Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|   |");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 2:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                    Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 3:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                    Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 4:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 5:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 6:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 3); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 7:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 3); Console.Write("|ooo|");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 8:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|ooo|");
                    Console.SetCursorPosition(x, y + 3); Console.Write("|o o|");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|ooo|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
                case 9:
                    Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                    Console.SetCursorPosition(x, y + 2); Console.Write("|ooo|");
                    Console.SetCursorPosition(x, y + 3); Console.Write("|ooo|");
                    Console.SetCursorPosition(x, y + 4); Console.Write("|ooo|");
                    Console.SetCursorPosition(x, y + 5); Console.Write("-----");
                    break;
            }
        }
    }
}
