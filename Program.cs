// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 1. Imprimir 1-255​
Console.WriteLine("--------------- 1. Imprimir 1-255 ----------------");

static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.
    for (int i = 1; i<=255; i++)
    {
        Console.WriteLine(i);
    }
}
PrintNumbers();


// 2. Imprimir números impares entre 1-255​
Console.WriteLine("--------------- 2. Imprimir números impares entre 1-255 ----------------");
static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    for (int i = 1; i<=255; i++)
    {
        if (i % 2 != 0){
            Console.WriteLine(i);
        }
    }
}
PrintOdds();


// 3. Imprimir Suma 
Console.WriteLine("--------------- 3. Imprimir Suma  ----------------");

static void PrintSum()
{
    // Print all of the numbers from 0 to 255,
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int sum = 0;
    for (int i = 0; i<=255; i++)
    {
        sum = sum + i;
        Console.WriteLine($"New number: {i} Sum: {sum}");
    }
}
PrintSum();


// 4. Iterar a través de una matriz​
Console.WriteLine("--------------- 4. Iterar a través de una matriz ----------------");

static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
LoopArray(new int[] {1, 2, 3, 4, 5});



// 5. Encuentra el valor máximo
Console.WriteLine("--------------- 5. Encuentra el valor máximo ----------------");

static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    if (numbers.Length == 0)
    {
        Console.WriteLine("El arreglo está vacío.");
    }
    int max = numbers[0]; // Suponemos que el primer elemento es el máximo inicialmente.
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number; // Actualizamos el máximo si encontramos un valor mayor.
        }
    }
    return max;
}

int[] array = new int[] { -3, -5, -7 };
int max = FindMax(array);
Console.WriteLine($"El número mayordel array es: {max}");



// 6. Obtén el Promedio​
Console.WriteLine("--------------- 6. Obtén el Promedio ----------------");

static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    if (numbers.Length == 0)
    {
        Console.WriteLine("El arreglo está vacío.");
        return; // No se puede calcular el promedio de un arreglo vacío.
    }

    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number; // Suma todos los números en el arreglo.
    }

    double average = (double)sum / numbers.Length; // Calcula el promedio.

    Console.WriteLine($"El valor promedio del array es: {average}");
}
int[] array2 = { 2, 10, 3 };
GetAverage(array2);



// 7. Lista con números impares
Console.WriteLine("--------------- 7. Lista con números impares ----------------");

static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
        List<int> oddNumbersList = new List<int>();
        for (int i = 1; i <= 255; i += 2)
        {
            oddNumbersList.Add(i);
        }
        return oddNumbersList;
}
List<int> oddNumbers = OddList();

Console.WriteLine("Lista de números impares del 1 al 255:");
foreach (int number in oddNumbers)
{
    Console.Write($"{number} ");
}

// 8. Mayor que Y
Console.WriteLine("--------------- 8. Mayor que Y ----------------");
static int GreaterThanY(List<int> numbers, int y)
{
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int count = 0;
    foreach (int number in numbers)
    {
        if (number > y)
        {
            count++;
        }
    }
    return count;
}
List<int> numbers = new List<int> { 1, 3, 5, 7 };
int y = 3;
int count = GreaterThanY(numbers, y);

Console.WriteLine($"Número de valores mayores que {y}: {count}");


// 9. Haz Cuadrar los Valores 
Console.WriteLine("--------------- 9. Haz Cuadrar los Valores ----------------");

static void SquareArrayValues(List<int> numbers2)
{
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    for (int i = 0; i < numbers2.Count; i++)
    {
        numbers2[i] = numbers2[i] * numbers2[i]; // Multiplica cada valor por sí mismo (eleva al cuadrado).
    }
    Console.WriteLine("Lista de valores al cuadrado:");
    foreach (int number in numbers2)
    {
        Console.Write($"{number} ");
    }
}

List<int> numbers2 = new List<int> {1, 5, 10, -10};
SquareArrayValues(numbers2);


// 10. Elimina los Números Negativos
Console.WriteLine("");
Console.WriteLine("--------------- 10. Elimina los Números Negativos ----------------");

static void EliminateNegatives(List<int> numbers3)
{
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    Console.WriteLine("Lista antes de eliminar los negativos:");
    foreach (int number in numbers3)
    {
        Console.Write($"{number} ");
    }
    for (int i = 0; i < numbers3.Count; i++)
    {
        if (numbers3[i] < 0)
        {
            numbers3[i] = 0; // Reemplaza cualquier número negativo con 0.
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Lista después de eliminar los negativos:");
    foreach (int number in numbers3)
    {
        Console.Write($"{number} ");
    }
}

List<int> numbers3 = new List<int> { 1, 5, 10, -2 };
EliminateNegatives(numbers3);