using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {

            // Dictionary irá armazenar os índices
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    //Retorna os índices do dois números somados que resultam em 9
                    return new int[] { map[complement], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    // Adiciona número e índice ao dicionário
                    map[nums[i]] = i;
                }
            }

            return new int[0];
        }
    }
}
