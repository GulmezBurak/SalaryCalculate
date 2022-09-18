//using System;
//using System.Timers;
SalaryCalculate();

void SalaryCalculate()
{
        try
    {
        Console.WriteLine("What is your annual salary earnings?");

        double salary = Convert.ToInt32(Console.ReadLine().TrimStart());
        double month = 12;
        double day = 365;
        double hour = 8765;
        double minute = 525948;
        double second = 31556926;

        
        if (salary >= 120000)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You are Tugay");
            Console.WriteLine("Your salary " + (Math.Round((salary / month), 2) + " in a month"));
            Console.WriteLine("Your salary " + (Math.Round((salary / day), 2) + " in a day"));
            Console.WriteLine("Your salary " + (Math.Round((salary / hour), 2) + " in a hour"));
            Console.WriteLine("Your salary " + (Math.Round((salary / minute), 2) + " in a minute"));
            Console.WriteLine("Your salary " + (Math.Round((salary / second), 2) + " in a second"));

        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("You are Burak");
            Console.WriteLine("Your salary " + (Math.Round((salary / month), 2) + " in a month"));
            Console.WriteLine("Your salary " + (Math.Round((salary / day), 2) + " in a day"));
            Console.WriteLine("Your salary " + (Math.Round((salary / hour), 2) + " in a hour"));
            Console.WriteLine("Your salary " + (Math.Round((salary / minute), 5) + " in a minute"));
            Console.WriteLine("Your salary " + (Math.Round((salary / second), 2) + " in a second"));
        }

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter correct value");
    }
    SalaryCalculate();
    Console.ReadLine();
}



//static void Main()
//{
//    Timer t = new Timer(1000);
//    Console.ReadLine();
//}

//static void TimerCallback(Object o)
//{
//    Console.WriteLine("In TimerCallback: " + DateTime.Now);
//}