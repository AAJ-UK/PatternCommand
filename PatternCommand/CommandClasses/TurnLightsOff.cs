using PatternCommand.CommandClasses;
using PatternCommand.ObjectsClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand.CommandClasses
{
    /// <summary>
    /// Each method in the main class is calles from this Command class
    /// A refernce of the object we want to work on is passed in through the constructor
    /// each classes execute method calls the appropriate method in the main class
    /// </summary>
    class TurnLightsOff : ICommand
    {
        readonly ICarFunctionList1 _Object;

        public TurnLightsOff(ICarFunctionList1 NewObject)
        {
            _Object = NewObject;
        }

        public void Execute()
        {
            _Object.TurnLightsOff();
        }

    }
}
