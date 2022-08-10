internal class Program
{
    private static void Main(string[] args)
    {
           void GreateNewArray(string[] Array, string[] NewArray, int Len)
        {
            int t = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Length <= Len)
                {
                    NewArray[t] = Array[i];
                    t++;
                }
            }
        }

        int Array(string[] Array, int LenString)
        {
            int res = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Length <= LenString) res++;
            }
            return res;
        }

        string PrintArray(string[] array)
        {
            string res2 = string.Empty;
            res2 = "[ ";
            for (int i = 0; i < array.Length; i++)
            {
                res2 += $"{array[i],1}";
                if (i < array.Length - 1) res2 += ", ";
            }
            res2 += " ]";
            return res2;
        }

        Console.Clear();
        string[] ArrStrings = new string[] { };
        ArrStrings = new string[] { "hello", "-2", "Hi all", ":-)", "578", "Samorodov" };
        int Length = 3;
        int FinalArray = Array(ArrStrings, Length);
        string[] ArrStrings2 = new string[FinalArray];
        GreateNewArray(ArrStrings, ArrStrings2, Length);
        Console.WriteLine($"{PrintArray(ArrStrings)} -> {PrintArray(ArrStrings2)}");

    }
}
