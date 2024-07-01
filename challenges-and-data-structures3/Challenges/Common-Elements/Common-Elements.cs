using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures3.Challenges.Common_Elements
{
    public class Common_Elements
    {
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            List<int> commonElements = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && !commonElements.Contains(arr1[i]))
                    {
                        commonElements.Add(arr1[i]);
                    }
                }
            }
            return commonElements.ToArray();
        }

    }

}
