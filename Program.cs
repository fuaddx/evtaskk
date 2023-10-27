using ConsoleApp7.Models;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Count notebook");
            int count = Convert.ToInt32(Console.ReadLine());
            
            // instance
           


            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Brand enter:");
                string brand = Console.ReadLine();
                Console.WriteLine("Price enter: ");
                int price = Convert.ToInt32(Console.ReadLine());

                Notebook notebook = new Notebook(brand, count, price);
            }


        }
    }
}