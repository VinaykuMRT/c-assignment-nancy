// See https://aka.ms/new-console-template for more information



class MyClass
{
    enum Grade { pass = 60, Distinction = 85 };
    public static void Main()
    {
        int empid;
        int mark;
        Console.WriteLine("Whats your empid?");
        empid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"thanks for giving your emp id {empid}");


        Console.WriteLine("Enter your TSQL mark?");
        mark = Convert.ToInt32(Console.ReadLine());
        if (mark >= (int)Grade.Distinction)
        {
            Console.WriteLine("You are in Distinction grade");
        }
        else if (mark >= (int)Grade.pass)
        { Console.WriteLine("You are in Pass Grade"); }
        else
        {
            Console.WriteLine("sorry, your grade is FAIL");
        }
    }
    }