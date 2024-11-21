namespace Challenge3_2
{
    internal class Program
    {
        // Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.
        static void Main(string[] args)
        {
            Console.WriteLine("Lets find the sum of a bunch of single-digit numbers");
            Console.WriteLine("Enter a bunch of single-digit numbers");
            Console.Write("Input: ");
            string numbers = Console.ReadLine();

            Console.WriteLine($"\nSum: { StringNumberSummation(numbers) }");
        }

        // Returns the sum of all single digits in string
        // Breaks the string into chars
        // Chars have their own number associated with them as long as we subtract the "char 0" from out string char digit we get the desired result
        // digits are as follows (0,1,2,3,4,5,6,7,8,9) => (48,49,50,51,52,53,54,55,56,57)
        static double StringNumberSummation(string numbers)
        {
            double sum = 0;
            foreach (var num in numbers)
            {
                if(Char.IsNumber(num))
                {
                    sum += num - '0';
                }    
            }
            return sum;
        }
    }
}
