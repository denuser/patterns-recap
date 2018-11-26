using System;

namespace Patterns.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new QuackBehavior();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real mallard suck");
        }
    }
}