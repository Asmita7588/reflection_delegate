using System.Reflection;
using ReflectionDemo;

internal class Program
{
    private static void Main(string[] args)
    {

        //To get the reference of the assembly we need to use the Assembly.Loadfile method
        
        var MyAssembly = Assembly.LoadFile(@"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\ReflectionDemo\SomeClassLibrary1\bin\Debug\net8.0\SomeClassLibrary1.dll");

        //we need to call the GetType method on the assembly reference, and to this get type method,
        //we need to provide the fully qualified name of the class i.e. Namespace.ClassName is as follows.
        //We need to fetch the details of the class Class1.

        Type myType = MyAssembly.GetType("SomeClassLibrary1.Class1");

        //To create an instance of a class dynamically in C#, we need to use Activator.CreateInstance method and to this method

        dynamic MyObject = Activator.CreateInstance(myType);

        //All Public fields
        Console.WriteLine("All public fields ");
        foreach (MemberInfo memberInfo in myType.GetFields())
        {
            Console.WriteLine(memberInfo.Name);
        }

        //All Public Properties
        Console.WriteLine("All public Properties ");
        foreach (MemberInfo memberInfo in myType.GetProperties())
        {
            Console.WriteLine(memberInfo.Name);
        }

        //All Public methods
        Console.WriteLine("All public Methods ");
        foreach (MemberInfo memberInfo in myType.GetMethods())
        {
            Console.WriteLine(memberInfo.Name);
        }


        //Delegets in c# 

       // 1)
        PrintMessage printMessageDel = new PrintMessage(DelegatesDemo.PrintToConsole);

        printMessageDel("Hello , Asmita!");

        // 2)

        PrintGreetings printGreetingsDel = DelegatesDemo.PrintToConsole;
        printMessageDel += DelegatesDemo.PrintToFile;

        //3

        Dictionary<string , MenuFunction> menu = new Dictionary<string , MenuFunction>
        {
            {"1", DelegatesDemo.ShowDate },
            {"2", DelegatesDemo.ShowTime },
            {"3", DelegatesDemo.Exit }
        };


        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Show Date");
            Console.WriteLine("2. Show Time");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (menu.ContainsKey(choice))
            {
                menu[choice]();
                if (choice == "3")
                    break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }

        //4

        Calculate cal = DelegatesDemo.Add;

        Console.WriteLine("Addition = " + cal(5, 6) );

        cal += DelegatesDemo.Sub;

        Console.WriteLine("Substraction = " + cal(10, 6));

        cal = DelegatesDemo.Multiply;

        Console.WriteLine("Multiplication = " +cal(4 , 3));

        //for non static method

        DelegatesDemo demo = new DelegatesDemo();

        cal += demo.Divide;

        Console.WriteLine("Division = " + cal(10, 5));


    }
    }