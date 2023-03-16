using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("문자열을 입력하세요: ");
        string str = Console.ReadLine();
        int vowelCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                vowelCount++;
            }
        }

        Console.WriteLine("입력한 문자열에서 모음의 개수는 " + vowelCount + "개 입니다.");
        Console.ReadKey();
    }
    
}
