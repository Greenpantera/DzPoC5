// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int SumElement(int[]array)
{
    int sum=0;
    for(int i=0; i<array.Length; i+=2) //Нечётная позици будет равна i=0, так как по человеческой версии тоит на нечётной позиции
    {
        sum+=array[i];  
    }
return sum;
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

int[]array=MakeNewArray(10,1,15);
int sum=SumElement(array);
Console.WriteLine($"В маcсиве [{string.Join(",", array)}] сумма чисел стоящих на нечётных позициях: {sum}");