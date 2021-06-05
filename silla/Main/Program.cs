using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace silla
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(600, 600);
            Main.Game gw = new Main.Game(window);
            
        }
    }
}
