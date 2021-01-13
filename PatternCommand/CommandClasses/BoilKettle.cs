using PatternCommand.ObjectsClasses;
using PatternCommand.CommandClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand.CommandClasses
{
    class BoilKettle : ICommand
    {
        readonly IKettle _Object;

        public BoilKettle(IKettle NewObject)
        {
            _Object = NewObject; ;
        }

        public void Execute()
        {
            _Object.BoilKettle();
        }
    }
}
