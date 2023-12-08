namespace assignement2
{
    internal class Program
    {
        static void Main()
        {
            
            {
                Console.WriteLine("Enter a four-digit number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 9999)
                {
                    Console.WriteLine("Please enter a valid four-digit number.");
                }
                else if (number == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine(numberstowords.ConvertToWords(number));
                }

            }
        }
    }

}
    
