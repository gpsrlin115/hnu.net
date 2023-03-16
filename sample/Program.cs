using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("숫자를 입력하세요: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("입력한 숫자는 양수입니다.");
        }
        else if (num < 0)
        {
            Console.WriteLine("입력한 숫자는 음수입니다.");
        }
        else
        {
            Console.WriteLine("입력한 숫자는 0입니다.");
        }
        Console.ReadKey();
    }
}
