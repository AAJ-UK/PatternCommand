using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand.ObjectsClasses
{
    class Kettle : IKettle
    {
        public void BoilKettle()
        {
            Console.WriteLine("kETTLE IS BOILED");
        }
    }
}
