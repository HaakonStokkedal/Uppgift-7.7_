namespace Uppgift_7._7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Str1 = { "a", "t", "t", "c", "hej" };
            string[] Str2 = { "a", "a", "hej", "b" };

            for (int i = 0; i < Str2.Length; i++)
            {
                Console.Write(FinnsIBåda(Str1, Str2)[i]);
                Console.Write(" ");
            }

            Console.ReadKey();
        }

        static string[] FinnsIBåda(string[] Str1, string[] Str2)
        {
            string[] Str3 = new string[Str2.Length];
            
            for (int i = 0; i < Str2.Length; i++)
            {
                for (int j = 0; j < Str1.Length; j++)
                {
                    if (Str2[i] == Str1[j])
                    {
                        Str3[i] = Str2[i];
                    }
                }
            }
            int counter = 0;
            for (int i = 0; i < Str3.Length; i++)
            {
                for (int j = i+1; j < Str3.Length; j++)
                {
                    if (Str3[i].CompareTo(Str3[j]) == 0)
                    {
                        Str3[j] = "";
                    }
                }
            }

            return Str3;
        }
    }
}