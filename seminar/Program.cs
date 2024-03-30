using System;

 
        while (true)
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine()!;
              int number =Convert.ToInt32(input);
            if (input == "q")
            {
                break;
            }

            
             
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                if (sum % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр введенного числа четная выход.");
                    break;
                }
            
            else
            {
                Console.WriteLine("Сумма цифр введенного числа нечетная вводите ещё");
            }
        }