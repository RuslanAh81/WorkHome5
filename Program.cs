//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int [] CreateRandomArray(int size)
{
    int[] newArray = new int [size];

    for (int i = 0; i < newArray.Length; i++)
      newArray[i] = new Random().Next(100, 1000);
      return newArray;
}

 void ShowArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

    Console.WriteLine();   

 }

 int  CountOfElement(int[]array)
 {
    int curr = 0;
     for(int i=0; i< array.Length; i++)
      {
        if(array[i] % 2 == 0)
    
        curr++;

      }
      return curr;   
 }


Console.WriteLine("input a number of elements : ");
int size =Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size);

ShowArray(myArray);

int countOfElement = CountOfElement(myArray);

Console.WriteLine("Количество четных чисел в массиве: " + countOfElement);
*/