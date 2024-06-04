namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsPalindrome(string s)
            {
                var reversedString = "";
                for (int i = s.Length - 1 ; i >= 0; i--)
                {
                    reversedString += s[i];
                }

                // if the reversed string is equal to the input string, then it's a palindrome
                return string.Equals(reversedString, s, StringComparison.InvariantCultureIgnoreCase); 
            }

            void Check(string s, bool shouldBePalindrome)
            {
                Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
            }

            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);            
        }
    }
}