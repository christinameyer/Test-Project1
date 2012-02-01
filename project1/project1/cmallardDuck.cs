using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1
{
    public class cmallardDuck : cDuck
    {
        public cmallardDuck
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }


}