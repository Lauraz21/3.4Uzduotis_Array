namespace _3._4Uzduotis_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3 };

            int[] result = RemoveElement(numbers);

            for (int k = 0; k < result.Length; k++)
            {
                Console.WriteLine(result[k]);
            }
        }

        public static int[] RemoveElement(int[] numbers)
        {
            int[] newArray = new int[numbers.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = numbers[i];
            }
            return newArray;
        }
    }
}