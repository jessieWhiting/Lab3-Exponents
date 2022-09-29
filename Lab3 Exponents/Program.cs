using System.Security.Cryptography.X509Certificates;

namespace Lab3_Exponents
{
    internal class Program
    {
        static void Main()
        {

            

            while (true)
            {
                Console.WriteLine(" Enter an integer");

                int num = Int32.Parse(Console.ReadLine());

                if (num < 1 || num >= 1291)
                {
                    Console.WriteLine("This is not a valid number.");
                    Main();
                }

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($" {"Number: ",10} {"Squared: ",20} {"Cubed: ",20} ");
                
                GetExponent(num);
             
                if (PlayAgain() == false)
                {
                    break;

                }
                
            }
            
        }
        public static void GetExponent(int num)
        {
            for (int i = 1; i < num +1; i++)
            {
                int squared = (int)Math.Pow(i, 2);
                int cubed = (int)Math.Pow(i, 3);

                Console.WriteLine($" {i, 10} { squared, 20} {cubed, 20} ");
            }   
        }
           
        static bool PlayAgain()
        {
            Console.WriteLine(" Would you like to run another number? Y/N? ");
            string again = Console.ReadLine().ToLower();
            if(again == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        
         
    }
}
