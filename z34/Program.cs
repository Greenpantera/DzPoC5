// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int CountDelNaDwa (int[]array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count++; 
        }
     }
return count;
}


int[] MakeNewArray(int size, int beginValue, int endValue)
{
    int[]array=new int[size];
    for(int i=0; i<size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
     }
    return array;
}

int[]array=MakeNewArray(10,100,1000);
int count=CountDelNaDwa(array);
Console.WriteLine($"В масиве [{string.Join(",", array)}] количество чётных чисел {count}");