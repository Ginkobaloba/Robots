using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
        public class twoStepRobot : Robot
        {
            public string shoeColor;

            public twoStepRobot(string name, string shoeColor)
        {
            this.Name = name;
            this.shoeColor = shoeColor;
            this.IsAlive = true;
        }
        public override void MoveForward()
        {
            Console.WriteLine("{0} takes two steps forward, in its {1} shoes. ", Name, shoeColor);
        }
        public override void MoveBack()
        {
            Console.WriteLine("{0} takes two steps back, in its {1} shoes. ", Name, shoeColor);
        }
        public override void MoveLeft()
        {
            Console.WriteLine("{0} takes two steps left, in its {1} shoes. ", Name, shoeColor);
        }
        public override void MoveRight()
        {
            Console.WriteLine("{0} takes two steps right, in its {1} shoes. ", Name, shoeColor);
        }
    }
}
