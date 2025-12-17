using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    internal interface IMovable
    {
        public void Move();
    }
    internal interface ISound
    {
        public void MakeSound();
    }
    internal class Robot : IMovable, ISound
    {
        public void Move()
        {
            Console.WriteLine("It can move");
        }
        public void MakeSound()
        {
            Console.WriteLine("It can make sound");
        }
    }
}