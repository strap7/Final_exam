// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Например, [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(',');
        string[] outputArray = new string[inputArray.Length];
        int count = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                outputArray[count] = str;
                count++;
            }
        }

        string[] resultArray = new string[count];
        Array.Copy(outputArray, resultArray, count);

        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        
            Console.WriteLine(str);
            
