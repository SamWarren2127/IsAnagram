namespace Anagram_Test_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i += 2)
            {
                Console.WriteLine(args[i] + Environment.NewLine);
                Console.WriteLine(args[i + 1] + Environment.NewLine);
                Console.WriteLine("Is Anagram = " + IsAnagram(args[i], args[i + 1]).ToString());
                Console.WriteLine(Environment.NewLine);
            }
        }

        private static bool IsAnagram(string s, string t)
        {
            var s1 = s.ToCharArray();
            var s2 = t.ToCharArray();
            var s3 = s1.Length > s2.Length ? s1 : s2;

            for (int i = 0; i <= s1.Length - 1; i++)
            {
                for (int j = 0; j <= s2.Length - 1; j++)
                {
                    if (Equals(s1[i], s2[j]))
                    {
                        s3[j] = ' ';
                        break;
                    }
                }
            }

            return string.IsNullOrWhiteSpace(new string(s2));
        }
    }
}