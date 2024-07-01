using challenges_and_data_structures3.Challenges.Common_Elements;

namespace challenges_and_data_structures3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };

            int[] result = Common_Elements.CommonElements(array1, array2);
            Console.WriteLine("Common Elements: " + string.Join(", ", result));
        }
    }
}
