using System;

class MainClass
{
    enum DayWeek {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Satuday };
    public static void Main()
    {
        int Number1, Number2;
        string Name, Operation, WantedProject, ContinueOrNot = "1";
        DayOfWeek DayOfWeek = DayOfWeek.Friday;

        Console.WriteLine("Type your name:");
        Name = Console.ReadLine();
        Console.WriteLine("Hello, " + Name);

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
                Console.WriteLine("Today is " + DayOfWeek);
                break;
            }
        } 

        Console.WriteLine("Completed operation!");

        Console.ReadLine();
    }
}