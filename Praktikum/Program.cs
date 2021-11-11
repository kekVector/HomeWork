// // Сформировать случайным образом целочисленный массив А из натуральных двузначных чисел.
// // Создать на его основе массив В, отбрасывая те, которые
// // -Нарушают порядок возрастания
// // больше среднего арифметического элементов А
// // четные


// Вариант 1

// int N = 20; // Количество элементов массива А

// int[] CreatMassivA(int value) // Заполняем массив размера N двузначными числами
// {
//     int[] arr = new int[value];
//     for(int i = 0; i < value; i++)
//     {
//         arr[i] = new Random().Next(10, 100);    

//     }
//     return arr;

// }

// int Srednee(int[] arr)//Считаем среднее арифметическое массива А
// {
//     int sum = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         sum += arr[i];

//     }
//     return sum/(arr.Length);
// }

// void PrintMassiv(int[] arr) // Вывод массивов
// { 
//     Console.WriteLine();
//     for(int i = 0; i < arr.Length; i++)
//     {           
//         Console.Write(arr[i]+" ");   
//     }    

// }

// int[] array = CreatMassivA(N); // Создаем массив А
// PrintMassiv(array); //Выводим заданный масив
// int sredA = Srednee(array); // Находим среднее массива А
// Console.WriteLine();
// Console.WriteLine("Среднее арифметическое массива А " + sredA); // Выводим среднее массива А

// int[] CreatMassivB(int[] arr, int sred) // Считаем массив В
// {
//     int[] newarr = new int[arr.Length]; //Создаем пустой массив
//     int N = 0; //счетчик размера итогового массива
//     int count = 0;//счетчик второго массива
//     for(int i = 0; i < arr.Length; i++)//Записываем в массив В удовлетворяющие условию 2 и 3 элементы
//     {
//         if(!(arr[i]> sred || (arr[i]%2==0)) )
//         {
//             newarr[count] = arr[i];  
//             count++;      
//         }
//     }

//     int countzero = 1; // счетчик i для нулей в массиве
//     bool True = true; // счетчик для вайл для поиска не нулей
//     for(int i = 1; i < newarr.Length; i++)//удаляем ненужные элементы по условию 1 и ищем размер итогового массива
//     {
//         if(newarr[i] != 0) // Проверяем, есть ли число
//         {
//             True = true; //обнуление переменных
//             countzero = 1;
//             while(True) //Находим не ноль до числа в массиве
//             {
//                 if(newarr[i-countzero] == 0)countzero++;
//                 else True = false;
//             }
//             if(newarr[i - countzero]>=newarr[i]) newarr[i]=0; //удаляем элемент по условию 1
//         }   
//         if(newarr[i] != 0) N++; //ищем размер массива
//     }
//     countzero = 0;
//     int[] newarr2 = new int[N]; // Итоговый массив для заполнения размером N
//     for(int i = 1; i < newarr.Length; i++)
//         {
//             if(newarr[i] != 0)
//             {
//                 newarr2[countzero] = newarr[i];
//                 countzero++;
//             }
//         }

//     return newarr2;
// }

// // int[] arrayB = CreatMassivB(array, sredA);
// // PrintMassiv(arrayB);


//Вариант 2


int N = 20; // Количество элементов массива А

int[] CreatMassivA(int value) // Заполняем массив размера N двузначными числами
{
    int[] arr = new int[value];
    for (int i = 0; i < value; i++)
    {
        arr[i] = new Random().Next(10, 100);

    }
    return arr;

}

void PrintMassiv(int[] arr) // Вывод массивов
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("");

}

int[] CutChetn(int[] arr) //Функция для форматирования по четным числам
{
    int[] array = new int[arr.Length];
    int count = 0; //счетчик для второго массива
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            array[count] = arr[i];
            count++;
        }

    }
    return array;
}

int Srednee(int[] arr)//Считаем среднее арифметическое массива А
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];

    }
    return sum / (arr.Length);
}

int[] SortByUp(int[] arr) // Сортировка по возрастанию
{

    int[] array = new int[arr.Length]; //Массив для результата
    int count = 1;
    array[0] = arr[0]; // Всегда первое число массива будет удовлетворять условиям
    for (int i = 1; i < arr.Length; i++)
    {
        if (array[count - 1] < arr[i])
        {
            array[count] = arr[i];
            count++;
        }
    }

    return array;
}

int[] SortBySred(int[] arr, int Sr)//Сортировка по среднему
{
    int[] array = new int[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < Sr) 
        {
            array[count] = arr[i];
            count ++;
        }
    }
    return array;
}

int[] MassivB(int num) //Решение задачи общее
{
    int[] A = CreatMassivA(num);
    PrintMassiv(A);
    
    int[] B = SortBySred(A, Srednee(A));
    Console.WriteLine($"Сортировка по среднему значению {Srednee(A)}");
    PrintMassiv(B);    

    B = CutChetn(B);
    Console.WriteLine("Сортировка по четности");
    PrintMassiv(B);

    B = SortByUp(B);
    Console.WriteLine("Сортировка по возрастанию");
    PrintMassiv(B);

    return CutZero(B);

}

int[] CutZero(int[] arr) // Убираем из массива нули
{
    int[] array = arr;
    int count = 0;
    while(true)
    {
        if (arr[count]!=0) count ++;
        else break;
    }
    Array.Resize(ref array, (count));
    return array;
}

// int[] A = CreatMassivA(N);
// PrintMassiv(A);
int[] B = MassivB(N);

PrintMassiv(B);