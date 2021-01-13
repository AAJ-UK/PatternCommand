using PatternCommand.CommandClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand.BrokerClasses
{
    /// <summary>
    /// The Broker class builds up a list of commands. Each command command contains a reference
    /// to the main class and also has an execute method. When the execute method in each comand class is called,
    /// it then calls the corresponding mehod in the main class.
    /// </summary>
    class Broker
    {
        readonly IList<ICommand> Commands = new List<ICommand>();

        public void AddCommand(ICommand newCommand)
        {
            Commands.Add(newCommand);
        }

        public void ExecuteCommands()
        {
        foreach (ICommand c in Commands)
            {
                c.Execute();
            }
        }

    }
}
