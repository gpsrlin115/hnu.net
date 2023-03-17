using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("숫자를 입력하세요 (여러 개의 숫자를 입력하려면 띄어쓰기로 구분하세요): ");
        string input = Console.ReadLine();
        string[] nums = input.Split();
        List<int> uniqueNums = new List<int>();
        HashSet<int> checkedNums = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int num = int.Parse(nums[i]);
            if (!checkedNums.Contains(num))
            {
                checkedNums.Add(num);
                if (!uniqueNums.Contains(num))
                {
                    uniqueNums.Add(num);
                }
            }
        }

        Console.WriteLine("중복되지 않은 숫자들: " + string.Join(" ", uniqueNums));
        Console.ReadKey();
    }
}
