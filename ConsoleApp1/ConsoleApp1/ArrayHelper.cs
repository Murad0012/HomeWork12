namespace ConsoleApp1
{
    public class ArrayHelper
    {
        public static void Add(ref string[] array1, string a)
        {
            Array.Resize(ref array1, array1.Length + 1);
            array1[array1.Length - 1] = a;
            foreach (string s in array1)
            {
                Console.WriteLine(s);
            }
        }
        public static void Remove(ref string[] arr, string a)
        {
            arr = arr.Where(o => o != a).ToArray();
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}