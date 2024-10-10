using System.Text.RegularExpressions;

namespace EmailExtractionRegexAdvanceEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Contact us at support@example.com or sales@example.org";

            ExtractPatterns(input);
            Console.ReadKey();
        }

        static void ExtractPatterns(string input)
        {
            string pattern = @"(\w+)@(\w+)(\.\w+)";
            Regex regex = new Regex(pattern);            

            MatchCollection matchCollection = regex.Matches(input);

            //Console.WriteLine(matchCollection[0].Value);  // In case of only 1 match            

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine(group[0].Value);
            }
        }
    }
}
