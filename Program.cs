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



        PrintMessage printMessageDel = new PrintMessage(DelegatesDemo.PrintToConsole);

        printMessageDel("Hello , Asmita!");

    }
}