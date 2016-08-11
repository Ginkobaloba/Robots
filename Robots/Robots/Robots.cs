using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Robot
    {
        public string Name;
        public bool IsAlive;

        public Robot()
        {

        }
        public virtual void MoveForward()
        {
            Console.WriteLine("{0} takes one step forward", Name);
        }
        public virtual void MoveBack()
        {
            Console.WriteLine("{0} takes one step back", Name);
        }
        public virtual void MoveLeft()
        {
            Console.WriteLine("{0} takes one step left", Name);
        }
        public virtual void MoveRight()
        {
            Console.WriteLine("{0} takes one step left", Name);
        }
    }
}



