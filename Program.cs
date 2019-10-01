using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine(@"
   _____ __         ____  _               __      __  
  / ___// /____  __/ __ \(_)___ ___      / /___  / /_ 
  \__ \/ //_/ / / / /_/ / / __ `__ \__  / / __ \/ __ \
 ___/ / ,< / /_/ / _, _/ / / / / / / /_/ / /_/ / /_/ /
/____/_/|_|\__, /_/ |_/_/_/ /_/ /_/\____/\____/_.___/ 
          /____/                                      
");

        Console.WriteLine("Jimothy: Hey you, Your'e finally awake. What is thou's name?");

        string PlayerName = Console.ReadLine();

        Console.WriteLine("Jimothy: " + PlayerName + ", Ahead lies many dangerous trails, are you sure you wish to proceed? yes or no");

        string ending1 = Console.ReadLine();

        if (ending1 == "punch")
        {
            Console.WriteLine("-You instantly tell the man infront of you is dangerous and proceed to knock him out-");

        }
        else if(ending1 == "no")
        {
            Console.WriteLine("-You are a huge pussy.The end-");
        }
        else
        {
            Console.WriteLine("yes");
        }
    }
}