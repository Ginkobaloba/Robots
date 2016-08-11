using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class ShufflingShoeLessRobot : Robot
    {
        bool healedStump;

        public ShufflingShoeLessRobot(string name, bool healedStump)
        {
            this.Name = name;
            this.healedStump = healedStump;
            this.IsAlive = true;
        }
        public override void MoveForward()
        {
            if (GetStumpStatus())
            {
                Console.WriteLine("{0} takes a swift step forward", Name);
            }
            else
            {
                Console.WriteLine("{0} hobbles one step forward on a bloody stump of a foot", Name);
            }

        }
        public override void MoveBack()
        {
            if (GetStumpStatus())
            {
                Console.WriteLine("{0} takes a swift step back", Name);
            }
            else
            {
                Console.WriteLine("{0} hobbles one step forward on a bloody stump of a foot", Name);
            }

        }
        public override void MoveLeft()
        {
            if (GetStumpStatus())
            {
                Console.WriteLine("{0} takes a swift step left", Name);
            }
            else
            {
                Console.WriteLine("{0} hobbles one step left on a bloody stump of a foot", Name);
            }

        }
        public override void MoveRight()
        {
            if (GetStumpStatus())
            {
                Console.WriteLine("{0} takes a swift step left", Name);
            }
            else
            {
                Console.WriteLine("{0} hobbles one step left on a bloody stump of a foot", Name);
            }

        }

        public bool GetStumpStatus()
        {
            return this.healedStump;
        }
    }
}
