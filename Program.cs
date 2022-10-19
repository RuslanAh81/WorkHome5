//Задача1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
/*
// Задача2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray(int size)
{
    int[] newArray = new int [size];

    for (int i = 0; i < newArray.Length; i++)
      newArray[i] = new Random().Next(1, 100);
      return newArray;
}

 void ShowArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

    Console.WriteLine();   

 }

 int SumOfOddnumber(int [] array)
 {
  int summ = 0;
  for (int i = 0; i <array.Length; i++)
  {
      if(i % 2 ==1 )
      summ = summ + array[i];
  }
    return summ;
 }

 Console.WriteLine("input a number of elements : ");
int size =Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size);

ShowArray(myArray);

int SumOfElements = SumOfOddnumber(myArray);

Console.WriteLine("Сумма элементов нечетных позиций = " + SumOfElements);
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRandomArray(int size)
{
    double[] newArray = new double [size];

    for (int i = 0; i < newArray.Length; i++)
      newArray[i] = new Random().Next(1, 100);
      return newArray;
}

 void ShowArray(double[] array)
 {
    for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

    Console.WriteLine();   
 }

 double DifferentOfNum(double[] array)
 {
  double diff=0;
  double max=array[0];
  double min=array[0];
  
  for(int i = 0; i< array.Length; i++)
  {
    if ( array[i]< min)
    
    min = array[i];
    
    if (array[i]>max)
    
    max = array[i];
    
  diff = max - min;
  }

  return diff;

 }

Console.WriteLine("input a number of elements : ");
int size =Convert.ToInt32(Console.ReadLine());

double [] myArray = CreateRandomArray(size);

ShowArray(myArray);

double DiffOfElements =  DifferentOfNum(myArray);

Console.WriteLine("Разница между максимальным и минимальным элементом = " + DiffOfElements);