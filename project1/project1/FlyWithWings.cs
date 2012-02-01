using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1
{
    public class FlyWithWings : FlyBehavior
    {
        public override void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
