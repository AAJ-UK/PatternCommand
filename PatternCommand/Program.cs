using PatternCommand.BrokerClasses;
using PatternCommand.CommandClasses;
using PatternCommand.ObjectsClasses;
using PatternCommand.CommandClasses;
using System;

namespace PatternCommand
{/// <summary>
/// Command Pattern
/// Objects can have methods that perform ations
/// This pattern allows the programmer to build up a set of instructions (commands) that the main obect has to perform.
/// These small classes are sent into a broker class and the broker class uses the instructions to activate the 
/// corresponding method within the main class 
/// 
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Our main class is a car. We will create 3 cars
            Car CarNo1 = new Car("Car Number 1");
            Car CarNo2 = new Car("Car Number 2");
            Car CarNo3 = new Car("Car Number 3");

            // Sometime during the process we might want a drink
            Kettle kettle = new Kettle();


            // each car has 4 methodsm StartEngine,TurnLightsOn,TurnLightsOff and StopEngine
            // we create a command class which the broker class will use to call the correct method of the correct car.
            ICommand Car1StartEngine = new StartEngine(CarNo1);
            ICommand Car2StartEngine = new StartEngine(CarNo2);
            ICommand Car3StartEngine = new StartEngine(CarNo3);

            ICommand Car1TurnLightsOn = new TurnLightsOn(CarNo1);
            ICommand Car2TurnLightsOn = new TurnLightsOn(CarNo2);
            ICommand Car3TurnLightsOn = new TurnLightsOn(CarNo3);

            ICommand Car1TurnLightsOff = new TurnLightsOff(CarNo1);
            ICommand Car2TurnLightsOff = new TurnLightsOff(CarNo2);
            ICommand Car3TurnLightsOff = new TurnLightsOff(CarNo3);

            ICommand Car1StopEngine = new StopEngine(CarNo1);
            ICommand Car2StopEngine = new StopEngine(CarNo2);
            ICommand Car3StopEngine = new StopEngine(CarNo3);

            ICommand boilKettle = new BoilKettle(kettle);

            // we add the list of instructions into the broker class
            // if we change the order added, the order in which the methods are called changes
            // the proker class can operate in other ways aswell
            Broker Instructions = new Broker();
            Instructions.AddCommand(Car1StartEngine);
            Instructions.AddCommand(Car2StartEngine);
            Instructions.AddCommand(Car3StartEngine);

            Instructions.AddCommand(Car1TurnLightsOff);
            Instructions.AddCommand(Car2TurnLightsOff);
            Instructions.AddCommand(Car3TurnLightsOff);

            Instructions.AddCommand(Car1TurnLightsOn);
            Instructions.AddCommand(Car2TurnLightsOn);
            Instructions.AddCommand(Car3TurnLightsOn);

            // Have a brew. The Broker has no idea what it is doing
            // so a completely different type can be used in the same list
            // so long as it implemts ICommand
            Instructions.AddCommand(boilKettle);

            Instructions.AddCommand(Car1StopEngine);
            Instructions.AddCommand(Car2StopEngine);
            Instructions.AddCommand(Car3StopEngine);

            // After the broker class has been configured, we tell it to exectute all the commands
            Instructions.ExecuteCommands();


        }
    }
}
