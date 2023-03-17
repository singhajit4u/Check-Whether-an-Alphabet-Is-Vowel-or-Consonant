namespace Check_Whether_an_Alphabet_Is_Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the alphabet to check Vowel or Consonent:");
            char ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.Write($"{ch} :Vowel");    
            }
            else
            {
                Console.Write($"{ch} :Consonent");

            }
        }
    }
}