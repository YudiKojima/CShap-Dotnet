using System;

class MainClass
{
    enum TypeOfTransport {Car, Bus, Motobike, Plane, Boat};
    public static void Main()
    {
        int Number1, Number2;
        string Name, Operation, WantedProject, NumberTransport, ContinueOrNot = "1";
        string GoToTop;
        TypeOfTransport Transport = 0;

        Console.WriteLine("Type your name:");
        Name = Console.ReadLine();
        Console.WriteLine("Hello, " + Name);

        initial:

        while (ContinueOrNot == "1")
        {
            Console.WriteLine("Which project do you want to try?");
            Console.WriteLine("1 - Mathematical operation");
            Console.WriteLine("2 - Enum project");
            WantedProject = Console.ReadLine();

            if (WantedProject == "1")
            {
                Console.WriteLine("Enter first number:");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                Number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose which operation you want:");
                Console.WriteLine("1 - Sum");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Operation = Console.ReadLine();

                switch (Operation)
                {
                    case ("1"):
                        Console.WriteLine("The sum is: " + (Number1 + Number2));
                        break;
                    case ("2"):
                        Console.WriteLine("The subtraction is: " + (Number1 - Number2));
                        break;
                    case ("3"):
                        Console.WriteLine("The multiplication is: " + (Number1 * Number2));
                        break;
                    case ("4"):
                        Console.WriteLine("The division is: " + (Number1 / Number2));
                        break;
                    default:
                        Console.WriteLine("Operation number invalid");
                        break;
                }

                Console.WriteLine("1 - Continue");
                Console.WriteLine("0 - Exit");
                ContinueOrNot = Console.ReadLine();
                Console.Clear();
            } else {
                Console.WriteLine("Choose the type of trasnport:");
                Console.WriteLine("1 - Car");
                Console.WriteLine("2 - Bus");
                Console.WriteLine("3 - Motorbike");
                Console.WriteLine("4 - Plane");
                Console.WriteLine("5 - Boat");
                NumberTransport = Console.ReadLine();
                Console.Clear();

                switch (NumberTransport)
                {
                    case ("1"):
                        Transport = TypeOfTransport.Car;
                        break;
                    case ("2"):
                        Transport = TypeOfTransport.Bus;
                        break;
                    case ("3"):
                        Transport = TypeOfTransport.Motobike;
                        break;
                    case ("4"):
                        Transport = TypeOfTransport.Plane;
                        break;
                    case ("5"):
                        Transport = TypeOfTransport.Boat;
                        break;
                    default:
                        Console.WriteLine("Operation number invalid");
                        break;
                }

                Console.WriteLine("Transport chosen was: " + Transport);
                if(Transport == TypeOfTransport.Car)
                {
                    Console.WriteLine("Waiting time is: 60 minutes");
                } else if(Transport == TypeOfTransport.Bus)
                {
                    Console.WriteLine("Waiting time is: 120 minutes");
                } else if(Transport == TypeOfTransport.Motobike){
                    Console.WriteLine("Waiting time is: 30 minutes");
                } else if (Transport == TypeOfTransport.Plane)
                {
                    Console.WriteLine("Waiting time is: 20 minutes");
                } else
                {
                    Console.WriteLine("Waiting time is: 240 minutes");
                }
                break;
            }
        } 

        Console.WriteLine("Completed operation!");
        Console.Clear();

        Console.WriteLine("Want to go back to the beginning?");
        Console.WriteLine("[Y] - YES");
        Console.WriteLine("[N] - NO");
        GoToTop = Console.ReadLine();

        if( GoToTop.ToLower() != "y")
        {
            Console.WriteLine("See you later!");
        } else
        {
            goto initial;
        }

        Console.ReadLine();
    }
}