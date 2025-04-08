namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine(a > b); 
        Console.WriteLine(a < c); 
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a > b || a > c);
        bool isRaining = true;
        bool haveUmbrella = false;
        Console.WriteLine("Take an umbrella!");
        Console.WriteLine("You're good to go!");
        if (0 < 5);
        Console.WriteLine("Ticket is free!");
        if (5 >= 12);
        Console.WriteLine("Child ticket: $5");
        if (13 >= 64);
        Console.WriteLine("Standard ticket: $10");
        if (64 >= 100);
        Console.WriteLine("Senior ticket: $6");
        
        int day = 4;
        switch (day) 
      {
        case 1:
        Console.WriteLine("Monday");
        break;
        case 2:
        Console.WriteLine("Tuesday");
        break;
        case 3:
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thursday");
        break;
        case 5:
        Console.WriteLine("Friday");
        break;
        case 6:
        Console.WriteLine("Saturday");
        break;
        case 7:
        Console.WriteLine("Sunday");
        break;
      }
