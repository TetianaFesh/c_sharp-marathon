using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint3.Task5
{
    
    public class EventProgram
    {
        public delegate void EventHandler();
        public event EventHandler Show;
        public static void Dog()
        {
            Console.WriteLine("Dog");
        }

        public static void Cat()
        {
            Console.WriteLine("Cat");
        }

        public static void Mouse()
        {
            Console.WriteLine("Mouse");
        }

        public static void Elephant()
        {
            Console.WriteLine("Elephant");
        }

        public EventProgram()
        {
            Show = Show + Dog + Cat + Mouse + Elephant;
            Show();
        }
    }    
}
