using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[5] {1,2,3,4,5};
            int testTarget = 7;
            var result = TwoSum(testArray, testTarget);
            Console.WriteLine("Result: {0} : {1}", result[0], result[1] );
            Console.ReadLine();
        }

        static int[] TwoSum(int[] nums, int target){
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            int numberToFind = 0;

            for(int i = 0; i < nums.Length; i++){
                numberToFind = target - nums[i];
                
                if (hashMap.ContainsKey(numberToFind)){
                    return new int[2] { hashMap.GetValueOrDefault(numberToFind), i};
                }

                hashMap.TryAdd(nums[i], i);
            }

            return null;
        }
    }
}
