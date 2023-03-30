namespace TestConsole
{
    class Kata
    {
        static void Main()
        {
            //Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
            // Console.WriteLine(SymaChisel(723));
            Console.WriteLine(VxodChisla(5));

  
        }

        public static int VxodChisla(int a)
        {
            int result = 0;

            for (int i = 0; i == a; i--)
            {
                result = i;
            }
            return result;
        }




        public static int SymaChisel(int n)
        {
            while (n > 9)
            {
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                n = sum;
            }
            return n;
        }
        public static string ToJadenCase(string slovo)
        {            
            string[] words = slovo.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                string first = word[0].ToString().ToUpper();
                string end = word.Substring(1);
                string corectslovo = first + end + " ";
                result += corectslovo;
            }
            return result.TrimEnd();            
        }

    }
        
}



    
