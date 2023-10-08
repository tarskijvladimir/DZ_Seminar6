// Пользователь вводит с клавиатуры M  чисел. Посчитайте, сколько чисел больше 0 ввел пользователь



       int count = 0;
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
    
        for (int i = 0; i < numbers.Length; i++)
         {
            if (int.TryParse(numbers[i], out int n) && n > 0)
         {
            count++;
         }}

    //     foreach (string number in numbers) 
    //     {
    //         if (int.TryParse(number, out int n) && n > 0)
    //         {
    //             count++;
    //         }
    //    }
        Console.WriteLine($"Количество чисел больше нуля: {count}");
    

