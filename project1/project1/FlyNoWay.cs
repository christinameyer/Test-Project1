using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1
{
    public class FlyNoWay : FlyBehavior
    {
        public override void fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}