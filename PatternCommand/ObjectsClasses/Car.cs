using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand.ObjectsClasses
{
    /// <summary>
    /// This is the class that has to do something. The broker class will call the different methods of the class
    /// as it needs them
    /// </summary>
    class Car : ICarFunctionList1
    {
        public string _CarName { get; set; }
        public Car(string CarName)
        {
            _CarName = CarName;
        }

        public void StartEngine()
        {
            Console.WriteLine("{0} : Engine Started",_CarName);
        }

        public void StopEngine()
        {
            Console.WriteLine("{0} : Engine Stopped", _CarName);
        }

        public void TurnLightsOff()
        {
            Console.WriteLine("{0} : Lights On", _CarName);
        }

        public void TurnLightsOn()
        {
            Console.WriteLine("{0} : Lights Off", _CarName);
        }
    }
}
