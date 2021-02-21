using System;

namespace DopDZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Дополнительное задание для первого урока Введение в C#
            Console.WriteLine("Программа для проверки корректности пароля.\n" +
                "Пароль должен содержать от 4-х до 6-ти цифр, другие символы запрещены.\n" +
                "Для выхода из программы необходимо ввести exit");
            string str;
            do
            {
                bool flag = true;
                bool check = true;
                str = Console.ReadLine();
                if (str == "exit")
                    break;
                if (str.Length >= 4 && str.Length <= 6)
                {
                    char[] ar = str.ToCharArray();
                    for(int i = 0; i < str.Length; i++)
                    {
                        if (!char.IsDigit(ar[i]))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        for (int i = 0; i < str.Length - 1; i++)
                        {
                            if (ar[i] == ar[i + 1])
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check == true)
                        {
                            Console.WriteLine($"{str} Соответствует требованию!");
                        }
                        else
                            Console.WriteLine($"{str} Не соответствует требованию! Одинаковые цифры стоят подряд!");
                    }
                    else
                        Console.WriteLine($"{str} Не соответствует требованию! Используются запрещённые символы!");
                }
                else
                    Console.WriteLine($"{str} Не соответствует требованию! Длина пароля не соответствует заданной!");
            }
            while (true);
            Console.ReadKey();
            #endregion
        }
    }
}
