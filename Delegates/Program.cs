using System;


namespace Delegates
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleReader ru = new ConsoleReader();
            string exit = "1";
            while (exit != "0")
            {
                Console.WriteLine("WELCOME PLEASE ENTER THE OPTION\n 1.START \n0.EXIT");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter the value");
                    ru.Run();
                }

                else if (option == "0")
                {
                    exit = "0";
                }
                else
                {
                    Console.WriteLine("invalid Option\n");
                }
            }
        }
        

    }
   public  class ConsoleReader
    {
        public  Object Run()
        {
            DelegatesClass maincheck = new DelegatesClass();
            InputDelegate OnNumber = maincheck.OnNumber;
            InputDelegate OnWord = maincheck.OnWord;
            InputDelegate OnJunk = maincheck.OnJunk;
            string InputValue = Console.ReadLine();
            Object check = Condition.LoopCondition(InputValue, OnNumber, OnWord, OnJunk);
            return check;
        }
    }
}
