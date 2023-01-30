    internal class Program
    {
        static void Main(string[] args)
        {
            string[] basedArr = new string[] { "hello", "2", "world", ":-)" };
            string[] resArr = new string[0];

            foreach (var item in basedArr)
            {
                if (item.Length <= 3)
                {
                    Array.Resize(ref resArr, resArr.Length + 1);
                    resArr[resArr.Length - 1] = item;
                }
            }
            Console.WriteLine($"[{String.Join("; ", resArr)}]");
        }
    }