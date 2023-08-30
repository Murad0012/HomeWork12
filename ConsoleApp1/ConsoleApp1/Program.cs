namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "1", "2", "3", "4", "5" };
            string a = "6";
            ArrayHelper.Add(ref array1, a);
            ArrayHelper.Remove(ref array1, array1[0]);
        }
    }
}