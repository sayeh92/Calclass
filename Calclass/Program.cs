namespace Calclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 ;
            double num2;
            int opt;
            bool loop = true;
           

            while (loop)
            {

                Console.Clear();

                Console.Write("----------------------calculator-------------------------\n");
                Menu();

                Console.Write("Enter the first Number :");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the second Number :");
                num2 = double.Parse(Console.ReadLine()); ;


                opt = Convert.ToInt32(Console.ReadLine());
              



                switch (opt)
                {
                    case 1:
                        
                        cal.Addition();
                         break;

                    case 2:
                     

                        break;

                    case 3:
                      

                        break;

                    case 4:
                        
                        break;

                    case 5:
                        loop = false;
                        break;

                    default:
                        Console.Write("Input correct option\n");
                        break;

                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(); //without this line, the loop will work but the switch cases will not work. it is just a loop of menu without any adding and so on.

                static void Menu()
                {
                    Console.WriteLine("----- Menu -----");
                    Console.WriteLine("1: +");
                    Console.WriteLine("2: -");
                    Console.WriteLine("3: *");
                    Console.WriteLine("4: /");
                    Console.WriteLine("5: exit");

                }


            }
        }
    }
}