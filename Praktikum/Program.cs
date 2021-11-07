// Сформировать случайным образом целочисленный массив А из натуральных двузначных чисел.
// Создать на его основе массив В, отбрасывая те, которые
// -Нарушают порядок возрастания
// больше среднего арифметического элементов А
// четные

int N = 20; // Количество элементов массива А

int[] CreatMassivA(int value) // Заполняем массив размера N двузначными числами
{
    int[] arr = new int[value];
    for(int i = 0; i < value; i++)
    {
        arr[i] = new Random().Next(10, 100);    
        
    }
    return arr;
    
}

int Srednee(int[] arr)//Считаем среднее арифметическое массива А
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];

    }
    return sum/(arr.Length);
}

void PrintMassiv(int[] arr) // Вывод массивов
{ 
    Console.WriteLine();
    for(int i = 0; i < arr.Length; i++)
    {           
        Console.Write(arr[i]+" ");   
    }    
    
}

int[] array = CreatMassivA(N); // Создаем массив А
PrintMassiv(array); //Выводим заданный масив
int sredA = Srednee(array); // Находим среднее массива А
Console.WriteLine();
Console.WriteLine("Среднее арифметическое массива А " + sredA); // Выводим среднее массива А

int[] CreatMassivB(int[] arr, int sred) // Считаем массив В
{
    int[] newarr = new int[arr.Length]; //Создаем пустой массив
    int N = 0; //счетчик размера итогового массива
    int count = 0;//счетчик второго массива
    for(int i = 0; i < arr.Length; i++)//Записываем в массив В удовлетворяющие условию 2 и 3 элементы
    {
        if(!(arr[i]> sred || (arr[i]%2==0)) )
        {
            newarr[count] = arr[i];  
            count++;      
        }
    }
    
    int countzero = 1; // счетчик i для нулей в массиве
    bool True = true; // счетчик для вайл для поиска не нулей
    for(int i = 1; i < newarr.Length; i++)//удаляем ненужные элементы по условию 1 и ищем размер итогового массива
    {
        if(newarr[i] != 0) // Проверяем, есть ли число
        {
            True = true; //обнуление переменных
            countzero = 1;
            while(True) //Находим не ноль до числа в массиве
            {
                if(newarr[i-countzero] == 0)countzero++;
                else True = false;
            }
            if(newarr[i - countzero]>=newarr[i]) newarr[i]=0; //удаляем элемент по условию 1
        }   
        if(newarr[i] != 0) N++; //ищем размер массива
    }
    countzero = 0;
    int[] newarr2 = new int[N]; // Итоговый массив для заполнения размером N
    for(int i = 1; i < newarr.Length; i++)
        {
            if(newarr[i] != 0)
            {
                newarr2[countzero] = newarr[i];
                countzero++;
            }
        }
    
    return newarr2;
}

int[] arrayB = CreatMassivB(array, sredA);
PrintMassiv(arrayB);