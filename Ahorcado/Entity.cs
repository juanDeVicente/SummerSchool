using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Entity
    {
        int x;
        int y;
        char[,] pixels;

        public Entity(int x, int y, char[,] pixels)
        {
            this.x = x;
            this.y = y;
            this.pixels = pixels;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < pixels.GetLength(0); i++)
            {
                for (int j = 0; j < pixels.GetLength(1); j++)
                    Console.Write(pixels[i, j]);
                Console.SetCursorPosition(x, y + i + 1);
            }
        }
    }
}
