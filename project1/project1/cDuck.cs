using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1
{
    public abstract class cDuck
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;

        public cDuck()
        {
        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void perfromQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
