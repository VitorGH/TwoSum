// See https://aka.ms/new-console-template for more information
using TwoSum;

int[] nums = {2, 11, 7, 15};
int target = 9;

Solution solution = new Solution();

int[] result = solution.TwoSum(nums, target);

Console.WriteLine($"Índices: [{string.Join(", ", result)}]");
