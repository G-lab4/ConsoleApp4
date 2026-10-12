namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region hw1
            //int[] ragac = { 5, 6, 2, 7 };
            //int Rame(int num1, int num2, int num3, int num4)
            //{

            //    return num1 + num2 + num3 + num4;
            //}
            //Console.WriteLine(string.Join(" ", ragac));
            //Console.WriteLine(Rame(5, 6, 2, 7));

            #endregion

            #region hw2
            //string Sentence(string word1, string word2, string word3, string word4, string word5)
            //{

            //    return word1 + word2 + word3 + word4 + word5;
            //}

            //Console.WriteLine(Sentence("Hi", "my", "name", "is", "Gabrieli"));
            #endregion

            #region hw3
            static string result(string[] masivi)
            {
                return string.Join(" ", masivi);
            }

            static void Main(string[] args)
            {
                string[] Words = { "hello", "my", "Name", "is", "Gabrieli" };

                Console.WriteLine(result(Words));
                Console.ReadKey();
            }
            #endregion
        }



    }
}
