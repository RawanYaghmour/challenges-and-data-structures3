using challenges_and_data_structures3.Challenges.Common_Elements;

namespace challenges_and_data_structures_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };
            int[] expected = { 2, 3 };
            Assert.Equal(expected, Common_Elements.CommonElements(array1, array2));
        }

        [Fact]
        public void Test2()
        {
            int[] array1 = { 79, 8, 15 };
            int[] array2 = { 23, 79, 8 };
            int[] expected = { 79, 8 };
            Assert.Equal(expected, Common_Elements.CommonElements(array1, array2));
        }
        
    }
}