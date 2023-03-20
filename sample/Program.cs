using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("문자열을 입력하세요: ");
        string input = Console.ReadLine();
        string[] words = input.Split();
        Dictionary<string, int> countDict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i].ToLower();
            if (!countDict.ContainsKey(word))
            {
                countDict.Add(word, 1);
            }
            else
            {
                countDict[word]++;
            }
        }

        int maxCount = 0;
        string maxWord = "";

        foreach (KeyValuePair<string, int> entry in countDict)
        {
            if (entry.Value > maxCount)
            {
                maxCount = entry.Value;
                maxWord = entry.Key;
            }
        }

        Console.WriteLine($"가장 많이 나오는 단어: {maxWord}, 개수: {maxCount}");
        Console.ReadKey();
    }
}
