using System;

namespace IndividueleOefeningen
{
    class Program
    {

        private static int testProp;
        public static int TestProp
        {
            get { return testProp; }
            set { testProp = value; }
        }
        
        static void Main(string[] args)
        {
            Program.TestProp = 5;
            while(true)
            {
                Console.WriteLine("Topic van de uit te voeren oefening?");
                Console.WriteLine("1. DateTime");
                Console.WriteLine("2. Eigen objecten");
                Console.WriteLine("3. Datastructuren");
                Console.WriteLine("4. Overerving");
                Console.WriteLine("5. Exception handling");
                int keuze = Convert.ToInt32(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        DateTimeOefeningen.ToonSubmenu();
                        break;
                    case 2:
                        EigenObjectOefeningen.ToonSubmenu();
                        break;
                    case 3:
                        Datastructuren.ToonSubmenu();
                        break;
                    case 4:
                        Overerving.ToonSubMenu();
                        break;
                    case 5:
                        ExceptionHandling.ToonSubmenu();
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze");
                        break;
                }
            }
        }
    }
}
